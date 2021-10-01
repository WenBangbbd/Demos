using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonsul.Extension
{
    public class ConsulOptions
    {
        public const string Postion = "ConsulConfig";
        public string ServiceName { get; set; }
        public string ServiceIP { get; set; }
        public int ServicePort { get; set; }
        public string HealthCheck { get; set; }
        public string ConsulAddress { get; set; }
        public string ServiceId { get; set; }
        public string ConsulCenter { get; set; }
        public int Weight { get; set; }
    }
}
