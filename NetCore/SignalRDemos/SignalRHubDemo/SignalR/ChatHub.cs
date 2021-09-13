using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemo.SignalR
{
    public class ChatHub : Hub<IChatClient>
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.ReceiveMessage(user, message);
        }
        public override Task OnConnectedAsync()
        {
            Console.WriteLine(Context.ConnectionId);
            return base.OnConnectedAsync();
        }
    }
}
