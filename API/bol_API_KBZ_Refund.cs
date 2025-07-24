using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_KBZ_Refund
    {
        public int ActionParam { get; set; }

        public string merch_order_id { get; set; }
        public string merch_code { get; set; }
        public string trans_order_id { get; set; }
        public string refund_status { get; set; }
        public string refund_order_id { get; set; }
        public double refund_amount { get; set; }
        public string refund_currency { get; set; }
        public string refund_time { get; set; }
        public string nonce_str { get; set; }
        public string sign_type { get; set; }
        public string sign { get; set; }
        public string reason { get; set; }

        public string CreatedBy { get; set; }
    }


    public class bol_API_KBZ_Refund_Log
    {
        public int ActionParam { get; set; }

        public string timestamp { get; set; }
        public string nonce_str { get; set; }
        public string method { get; set; }
        public string sign_type { get; set; }
        public string sign { get; set; }
        public string version { get; set; }
        public string appid { get; set; }
        public string merch_code { get; set; }
        public string merch_order_id { get; set; }
        public string refund_request_no { get; set; }    //Optional
        public string refund_reason { get; set; }

        public string CreatedBy { get; set; }
    }
}
