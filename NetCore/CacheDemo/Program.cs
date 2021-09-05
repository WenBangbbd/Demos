using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace CacheDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Microsoft.Extensions.Caching.Redis,应用该包
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        services.AddDistributedRedisCache(options =>
                        {
                            options.Configuration = "127.0.0.1:6379";
                            options.InstanceName = "";
                        });

                    });
                    builder.Configure(app =>
                    {
                        app.Run(ProcessRedis);
                    });
                })
                .Build()
                .Run();
            //内存缓存
            async Task ProcessRedis(HttpContext context)
            {
                var cache = context.RequestServices.GetService<IDistributedCache>();
                var dateTime = await cache.GetStringAsync("current");
                if (dateTime == null)
                {
                    await cache.SetStringAsync("current", dateTime = DateTime.Now.ToString());
                }
                await context.Response.WriteAsync((await cache.GetStringAsync("current")).ToString());
            }
            //内存缓存
            async Task Process(HttpContext context)
            {
                var cache = context.RequestServices.GetService<IMemoryCache>();
                if (!cache.TryGetValue("current", out DateTime dateTime))
                {
                    cache.Set("current", dateTime = DateTime.Now);
                }
                await context.Response.WriteAsync(cache.Get("current").ToString());
            }
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.Configure(app =>
                    {
                        app.Run(Process);

                    });
                })
                .ConfigureServices(services =>
                {
                    services.AddMemoryCache();
                })
                .Build()
                .Run();
            Console.WriteLine("Hello World!");
        }
    }
}
