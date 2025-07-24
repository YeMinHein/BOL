using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_Evo
    {
        
    }


    public class bol_API_GetCallBackRequest
    {
        public int ActionParam { get; set; }

        public string mm_order_id { get; set; }
        public string merch_order_id { get; set; }
        public string prepay_id { get; set; }
        public string trade_status { get; set; }
    }

    public class bol_API_Get_Evo_PAY_Transactions
    {
        public string BillInvoiceNo { get; set; }
        public string Merch_Order_ID { get; set; }
        public string BillMonth { get; set; }
    }

    public class bol_API_WMGetCallBackRequest
    {
        public int ActionParam { get; set; }
        public string transactionId { get; set; }
        public string status { get; set; }
    }
}
