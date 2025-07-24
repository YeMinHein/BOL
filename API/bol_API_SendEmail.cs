using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_SendEmail
    {
        public string? CustomerAccountNo { get; set; }
        public string? FromEmail { get; set; }
        public string? ToEmail { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public string? ActivityType { get; set; }
    }
}
