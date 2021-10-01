using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Product>> GetAll()
        {
            Console.WriteLine(Request.Host);
            return new List<Product>
            {
                new Product{Id=1,Name="123"},
                new Product{Id=2,Name="222"}
            };
        }
    }
}
