using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_GetActivityLog
    {
        public int? id { get; set; }
        public string? customer_account_no { get; set; }
        public string? description { get; set; }
        public string? activity_type { get; set; }
        public DateTime? activity_date { get; set; }

    }
}
