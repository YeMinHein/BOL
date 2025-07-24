using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_KBZ_OrderInfo
    {
        public int ActionParam { get; set; }
        public string appid { get; set; }
        public string merch_code { get; set; }
        public string prepay_id { get; set; }
        public string nonce_str { get; set; }
        public string sign { get; set; }
        public string sign_type { get; set; }
        public string timestamp { get; set; }
    }
}
