using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RabbitMQDemo.Consumer
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


            channel.QueueDeclare("confirm", false, false, false, null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (obj, e) =>
            {

                var message = Encoding.UTF8.GetString(e.Body.ToArray());
                Console.WriteLine("收到消息---------" + message);
                Task.Delay(2000).Wait();
                Console.WriteLine("处理结束消息++++++++" + message);
                channel.BasicAck(deliveryTag: e.DeliveryTag, multiple: false);

            };
            //定义应答策略
            channel.BasicConsume(queue: "confirm", autoAck: false, consumer: consumer);


            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
