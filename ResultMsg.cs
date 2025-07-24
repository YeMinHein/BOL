using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class ResultMsg
    {
        public string? Result { get; set; }
        public string? Exception { get; set; }
        public string? Message { get; set; }
        public dynamic? Data { get; set; }
    }
}
