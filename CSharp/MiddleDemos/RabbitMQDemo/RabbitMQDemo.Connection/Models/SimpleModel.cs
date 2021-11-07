using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Connection.Models
{
    /// <summary>
    /// 简单模式，就是创建一个队列不考虑数据安全等因素
    /// </summary>
    public class SimpleModel
    {
        /// <summary>
        /// 直接声明队列生成
        /// </summary>
        public virtual void Create()
        {
            //ip或者机器名
            var connectFactory = new ConnectionFactory()
            {
                HostName = "127.0.0.1",//主机，ip,也可以时localhost
                Password = "admin",//密码
                UserName = "admin",//用户名
                Port = 5672,//端口，不是15672
            };
            //创建链接
            using var connection = connectFactory.CreateConnection();
            using var channel = connection.CreateModel();
            //声明队列
            //queue队列名称，durable持久化，exclusive 独享，autoDelete自动删除，arguments参数
            channel.QueueDeclare(queue: "hello",//
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
            string message = "Hello World!";
            var body = Encoding.UTF8.GetBytes(message);
            //发布消息
            while (true)
            {
                channel.BasicPublish(exchange: "",
                               routingKey: "hello",
                               body: body);
                Task.Delay(1000).Wait();
            }
        }
        public virtual void Consume()
        {
            var connectFactory = new ConnectionFactory()
            {
                HostName = "localhost",
                Port = 5672,
                Password = "admin",
                UserName = "admin"
            };
            var connect = connectFactory.CreateConnection();
            var channel = connect.CreateModel();
            //声明队列，防止没有队列
            channel.QueueDeclare("hello", true, false, false, null);

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (obj, e) =>
            {
                Console.WriteLine(Encoding.UTF8.GetString(e.Body.ToArray()));
            };

            channel.BasicConsume("hello", true, consumer);

        }
    }
}
