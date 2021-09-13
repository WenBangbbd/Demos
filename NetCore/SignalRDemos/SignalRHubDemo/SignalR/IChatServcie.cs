using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemo.SignalR
{
    public interface IChatServcie
    {
        Task SendMessage(string user, string message);
    }
    public class ChatService : IChatServcie
    {
        public readonly IHubContext<ChatHub,IChatClient> _hub;

        public ChatService(IHubContext<ChatHub, IChatClient> hub)
        {
            _hub = hub;
        }

        public async Task SendMessage(string user, string message)
        {
            await _hub.Clients.All.ReceiveMessage(user, message);
        }
    }
}
