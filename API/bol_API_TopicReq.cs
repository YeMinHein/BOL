using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_TopicReq
    {
        public int? ActionParam { get; set; }
        public string? CustAccNo { get; set; }
        public string? Token { get; set; }
        public string? DeviceID { get; set; }
    }
}
