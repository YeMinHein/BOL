using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_XWF
    {
    }

    public class bol_API_XWF_MakePayment
    {
        public int ActionParam { get; set; }
        public double? amount { get; set; }
        public string currency { get; set; }
        public string hmac { get; set; }
        public string payment_id { get; set; }
        public string timestamp { get; set; }
    }

    public class bol_API_XWF_MobilePayments
    {
        public int ActionParam { get; set; }
        public string partner_id { get; set; }
        public string access_token { get; set; }
        public string payment_id { get; set; }
        public string hmac { get; set; }
        public string status { get; set; }    
        public string timestamp { get; set; }
    }

    public class bol_API_XWF_PaymentStatus
    {
        public int ActionParam { get; set; }
        public string payment_id { get; set; }
        public string hmac { get; set; }
        public string partner_id { get; set; }
        public string timestamp { get; set; }

        public string status { get; set; }      //Paymnent Status
    }
}
