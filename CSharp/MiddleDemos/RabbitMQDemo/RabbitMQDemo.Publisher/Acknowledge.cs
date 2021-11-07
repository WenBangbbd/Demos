using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Publisher
{
    class Acknowledge
    {

        public void Publish()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                Password = "admin",
                UserName = "admin",
                Port = 5672
            };
            var connection = factory.CreateConnection();


            var channel = connection.CreateModel();
            channel.ConfirmSelect();
            channel.QueueDeclare("confirm", false, false, false, null);

            for (int i = 0; i < 1000; i++)
            {
                var message = Encoding.UTF8.GetBytes(i.ToString());
                channel.BasicPublish(exchange: "", routingKey: "confirm", body: message);
                Console.WriteLine(i);
                Task.Delay(1000).Wait();
            }

            channel.WaitForConfirms();
        }
    }
}
