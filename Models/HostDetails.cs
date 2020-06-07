using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADR.Models
{
    public class HostDetails
    {

        public string Hostname { get; set; }
        public string HostIP { get; set; }

        public long PingTime { get; set; }
        public int TTL { get; set; }

        public string TimeNow {get;set;}

        public int Bytes { get; set; }
    }
}
