using Microsoft.AspNetCore.Mvc;
using Sonsul.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServiceConsumer.Controllers
{
    [Route("api/[controller]")]
    public class ConsumerController : ControllerBase
    {
        private ConsulServiceFactory _serviceFactory;

        public ConsumerController(ConsulServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        [HttpGet("product")]
        public async Task<IEnumerable<Product>> GetAll()
        {
            var service = _serviceFactory.GetAgentService("service-provider");
            //向服务发送请求
            using var httpClient = new HttpClient();
            var result = await httpClient.GetAsync($"http://{service.Address}:{service.Port}/api/product");
            var content = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                throw new Exception(content);
            }
            var pr= JsonSerializer.Deserialize<List<Product>>(content);
            return pr;
        }
    }
}
