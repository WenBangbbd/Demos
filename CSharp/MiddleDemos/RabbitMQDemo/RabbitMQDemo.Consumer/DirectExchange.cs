using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQDemo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Consumer
{
    public class DirectExchange:IConsumer
    {
        public void Consume()
        {
            Console.WriteLine("请输入队列名:");
            var queName = Console.ReadLine();
            Console.WriteLine("请输入路由Key:");
            var routKey = Console.ReadLine().Split(",");
            var channel = new ConnectionFactory()
                .CreateFactory()
                .CreateChannel()
                .BindExchange("direct", "direct", false, false, null)
                .BindQue(queName, true, false, false, null)
                .BindQueToExchange(queName, "direct", routKey, null);
            
            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var msg = Encoding.UTF8.GetString(e.Body.ToArray());
                Console.WriteLine("+++++++++++" + msg);
                Task.Delay(1000).Wait();
                Console.WriteLine("-----------" + msg);
            };
            channel.BasicConsume(queName, true, consumer);
        }
    }
}
