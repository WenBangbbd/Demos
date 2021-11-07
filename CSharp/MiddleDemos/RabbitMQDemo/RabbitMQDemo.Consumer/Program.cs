using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RabbitMQDemo.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {

            var ex = new DirectExchange();
            Task.Run(() => ex.Consume());

            while(true)
            {
                Task.Delay(1000).Wait();
            }
        }
    }
}
