using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_KBZ_QueryOrder
    {
        public int ActionParam { get; set; }
        public string merch_order_id { get; set; }
        public string BillInvoiceNo { get; set; }
    }
}
