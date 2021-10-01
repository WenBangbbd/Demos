using Consul;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonsul.Extension
{
    public class ConsulServiceFactory
    {
        private readonly ConsulClientConfiguration _options;

        public ConsulServiceFactory(IOptions<ConsulClientConfiguration> options)
        {
            _options = options.Value;
        }   

        public AgentService GetAgentService(string serviceName)
        {
            using var consul = new Consul.ConsulClient(_options);
            var services = consul.Agent.Services()
                                     .Result
                                     .Response
                                     .Values
                                     .Where(service => service.Service.Equals("service-provider", StringComparison.OrdinalIgnoreCase));
            var service = services.First();
            return service;
        }
    }
}
