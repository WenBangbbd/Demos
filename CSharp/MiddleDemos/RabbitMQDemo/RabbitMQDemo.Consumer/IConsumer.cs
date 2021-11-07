using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo.Consumer
{
    interface IConsumer
    {
        void Consume();
    }
}
