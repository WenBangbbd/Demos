using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RoutingDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //默认参数和特殊参数
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.ConfigureServices(services => services.AddRouting());
                    builder.Configure(app =>
                    {
                        app.UseRouting();
                        app.UseEndpoints(endpoint => endpoint.MapGet("weather/{city=12}/{year}.{month}.{day}", InvokAsync));
                    });
                })
                .Build()
                .Run();
            //可空的路由配置
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.ConfigureServices(services => services.AddRouting());
                    builder.Configure(app =>
                    {
                        app.UseRouting();
                        app.UseEndpoints(endpoint => endpoint.MapGet("weather/{city?}/{date?}", InvokAsync));
                    });
                })
                .Build()
                .Run();
            //限制类型的路由配置
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.ConfigureServices(services => services.AddRouting());
                    builder.Configure(app =>
                    {
                        app.UseRouting();
                        app.UseEndpoints(endpoint => endpoint.MapGet("weather/{city:Int}/{date:DateTime}", InvokAsync));
                    });
                })
                .Build()
                .Run();


            //简单的配置路由
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.ConfigureServices(services => services.AddRouting());
                    builder.Configure(app =>
                    {
                        app.UseRouting();
                        app.UseEndpoints(endpoint =>
                        {
                            endpoint.MapGet(pattern: "weather/{city}/{date}", InvokAsync);
                        });
                    });
                })
                .Build()
                .Run();



            static async Task InvokAsync(HttpContext httpContext)
            {
                var routeValues = httpContext.Request.RouteValues;
                foreach (var item in routeValues)
                {
                    await httpContext.Response.WriteAsync($"<h1>{item.Key}------{item.Value}</h1><br>");
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
