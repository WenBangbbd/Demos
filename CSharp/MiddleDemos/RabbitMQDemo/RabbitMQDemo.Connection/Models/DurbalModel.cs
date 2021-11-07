using RabbitMQ.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Connection.Models
{
    public class DurbalModel : SimpleModel
    {
        public override void Create()
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
                                 durable: true,//队列持久化
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
            string message = "Hello World!";
            var body = Encoding.UTF8.GetBytes(message);
            //消息持久化
            var pro = channel.CreateBasicProperties();
            pro.Persistent = true;
            //发布消息
            while (true)
            {
                channel.BasicPublish(exchange: "",
                               routingKey: "hello",
                               pro,
                               body: body);
                Task.Delay(1000).Wait();
            }
        }
    }
}
