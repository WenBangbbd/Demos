using System;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQDemo.Connection.Models;

namespace RabbitMQDemo.Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sim = new DurbalModel();
            Task.Run(()=>sim.Create());
            Task.Delay(1000).Wait();
            Task.Run(() => sim.Consume());

            Console.Read();
        }
    }
}
