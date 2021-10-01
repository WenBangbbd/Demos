using Consul;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sonsul.Extension
{
    public static class DependencyInjection
    {
        public static IApplicationBuilder RegisterConsul(this IApplicationBuilder app, Action<ConsulOptions> cfg)
        {
            try
            {
                var options = new ConsulOptions();
                cfg(options);
                ConsulClient client = new ConsulClient(c =>
                {
                    c.Address = new Uri(options.ConsulAddress);
                    c.Datacenter = options.ConsulCenter;
                });

                client.Agent.ServiceRegister(new AgentServiceRegistration()
                {
                    ID = options.ServiceId,
                    Name = options.ServiceName,//分组---根据Service
                    Address = options.ServiceIP,
                    Port = options.ServicePort,
                    Tags = new string[] { options.Weight.ToString() },//额外标签信息
                    Check = new AgentServiceCheck()
                    {
                        Interval = TimeSpan.FromSeconds(12),
                        HTTP = $"http://{options.ServiceIP}:{options.ServicePort}/api/Health", // 给到200
                        Timeout = TimeSpan.FromSeconds(5),
                        DeregisterCriticalServiceAfter = TimeSpan.FromSeconds(20)
                    }//配置心跳
                }).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Consul注册：{ex.Message}");
            }
            return app;
        }

        public static IServiceCollection AddConsul(this IServiceCollection services, Action<ConsulClientConfiguration> cfg)
        {
            services.Configure(cfg);
            services.AddSingleton<ConsulServiceFactory>();
            return services;
        }
    }
}
