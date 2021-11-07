using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dapr.PubSub.Controllers
{
    [Route("api/[Controller]")]
    public class DaprController : ControllerBase
    {
        [HttpGet("Pub")]
        public async Task PubAsync()
        {
            var data = new Order
            {
                orderId = "123456",
                productId = "67890",
                amount = 2
            };

            var daprClient = new DaprClientBuilder().Build();
            Console.WriteLine(JsonSerializer.Serialize(data));
            await daprClient.PublishEventAsync<Order>("pubsub", "newOrder", data);
            Console.WriteLine(JsonSerializer.Serialize("-----------------"));
        }
        [Topic("pubsub", "newOrder")]
        [HttpPost("/orders")]
        public async Task<ActionResult> SubAsync()
        {
            Console.WriteLine("+++++++++++++++++++++++==");
            return Ok();
        }
    }
}
