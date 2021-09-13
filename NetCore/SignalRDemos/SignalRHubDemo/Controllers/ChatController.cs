using Microsoft.AspNetCore.Mvc;
using SignalRDemo.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRHubDemo.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatServcie _chatClient;
        public ChatController(IChatServcie chatClient)
        {
            _chatClient = chatClient;
        }
        [HttpPost("SendMessage/{message}")]
        public async Task SendMessageAsync(string message)
        {
            await _chatClient.SendMessage("user", message);
        }
    }
}
