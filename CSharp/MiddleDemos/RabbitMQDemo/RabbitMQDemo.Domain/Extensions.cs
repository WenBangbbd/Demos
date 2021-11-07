using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Domain
{
    public static class Extensions
    {
        public static IConnectionFactory CreateFactory(this ConnectionFactory factory)
        {
            return new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "admin",
                Password = "admin"
            };
        }
        public static IModel CreateChannel(this IConnectionFactory factory)
        {
            return factory.CreateConnection().CreateModel();
        }

        public static IModel BindExchange(this IModel channel, string exchange, string type, bool durable, bool autoDelete, IDictionary<string, object> arguments)
        {
            channel.ExchangeDeclare(exchange, type, durable, autoDelete, arguments);
            return channel;
        }

        public static IModel BindQue(this IModel channel, string queue, bool durable, bool exclusive, bool autoDelete, IDictionary<string, object> arguments)
        {
            channel.QueueDeclare(queue, durable, exclusive, autoDelete, arguments);
            return channel;
        }
        public static IModel BindQueToExchange(this IModel channel, string queName,string type, IEnumerable<string> routingKey, IDictionary<string, object> arguments)
        {
            foreach (var item in routingKey)
            {
                channel.QueueBind(queName, type, item, arguments);
            }
            return channel;
        }


    }
}
