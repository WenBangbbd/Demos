using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemo.SignalR
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddChatServcies(this IServiceCollection services)
        {
           
            services.AddSingleton<IChatServcie, ChatService>();
            return services;
        }
        public static IApplicationBuilder UseChatServices(this IApplicationBuilder builder)
        {
            builder.UseEndpoints(cfg =>
            {
                cfg.MapHub<ChatHub>("/chat");
            });
            return builder;
        }
    }
}
