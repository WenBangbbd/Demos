using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Publisher
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectExchange shan = new();
            shan.Publish();

            
        }
    }
}
