using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Publisher
{
    public class ShanoutExchage
    {
        public void Pubish()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "admin",
                Password = "admin",
            };
            var conn = factory.CreateConnection();
            var channel = conn.CreateModel();
            channel.ExchangeDeclare("fanout", "fanout", false, false, null);


            for (int i = 0; i < 1000; i++)
            {
                var msg = Encoding.UTF8.GetBytes(i.ToString());
                channel.BasicPublish("fanout", "", null, msg);
                Console.WriteLine(i);
                Task.Delay(1000).Wait();
            }


        }
    }
}
