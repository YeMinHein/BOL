using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_KBZ_CallbackRequest
    {
        public int ActionParam { get; set; }
        public string notify_time { get; set; }
        public string merch_code { get; set; }
        public string merch_order_id { get; set; }
        public string mm_order_id { get; set; }
        public string total_amount { get; set; }
        public string trans_currency { get; set; }
        public string trade_status { get; set; }
        public string trans_end_time { get; set; }
        public string callback_info { get; set; }   //Optional
        public string nonce_str { get; set; }
        public string sign_type { get; set; }
        public string sign { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
