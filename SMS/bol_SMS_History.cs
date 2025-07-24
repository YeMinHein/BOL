using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.SMS
{
    public class bol_SMS_History
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? MobileNo { get; set; }
        public string? Name { get; set; }
        public string? Message { get; set; }
       public DateTime? SendDate { get; set; }
        public string CreatedBy { get; set; }

    }
}
