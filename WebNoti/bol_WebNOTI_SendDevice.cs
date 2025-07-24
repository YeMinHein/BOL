using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WebNoti
{
    public class bol_WebNOTI_SendDevice
    {
        public int ActionParam { get; set; }
        public int NotiSendID { get; set; }
        public string CustAccNo { get; set; }
        public string DeviceID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string merch_order_id { get; set; }
        public string mm_order_id { get; set; }
        public string PaymentOperator { get; set; }

        public string BodyDetail { get; set; }

    }
}
