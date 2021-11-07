using RabbitMQ.Client;
using RabbitMQDemo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Publisher
{
    public class DirectExchange
    {
        public void Publish()
        {
            var routkey = Console.ReadLine();
            var channel = new ConnectionFactory()
                .CreateFactory()
                .CreateConnection()
                .CreateModel()
                .BindExchange("direct", "direct", false, false, null);
            for (int i = 0; i < 1000; i++)
            {
                var msg = Encoding.UTF8.GetBytes(i.ToString());
                channel.BasicPublish("direct", routkey, null, msg);
                Console.WriteLine(i);
                Task.Delay(1000).Wait();
            }

        }
    }
}
