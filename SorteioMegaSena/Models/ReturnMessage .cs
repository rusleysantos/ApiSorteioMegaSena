using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaSena.Models
{
    public class ReturnMessage
    {
        public string Status { get; set; }
        public string MessageDev { get; set; }
        public string MessageUser { get; set; }
        public object Data { get; set; }
    }
}
