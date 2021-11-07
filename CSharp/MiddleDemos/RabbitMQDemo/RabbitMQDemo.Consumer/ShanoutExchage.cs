using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Consumer
{
    public class ShanoutExchage
    {
        public void publish()
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                Password = "admin",
                UserName = "admin",
            };
            var conn = factory.CreateConnection();
            var channel = conn.CreateModel();

            var queueName = channel.QueueDeclare().QueueName;

            channel.ExchangeDeclare("fanout", "fanout", false, false, null);
            channel.QueueBind(queueName, "fanout", "", null);

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (sender, e) =>
              {
                  var msg = Encoding.UTF8.GetString(e.Body.ToArray());
                  Console.WriteLine("+++++++++++" + msg);
                  Task.Delay(2000);
                  Console.WriteLine("-----------" + msg);
              };
            channel.BasicConsume(queueName, true, consumer);

        }
    }
}
