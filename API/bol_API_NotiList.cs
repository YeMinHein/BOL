using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_NotiList
    {
        public int? ID { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? SentDate { get; set; }
        public string Category { get; set; }
        public bool IsRead { get; set; }
    }

    public class bol_API_NotiListV2
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SentDate { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        //public string TxnImageUrl { get; set; }
        //public string PromoImageUrl { get; set; }
        public string InfoImageUrl { get; set; }
        public string PromoUrl { get; set; }
        public bool IsRead { get; set; }
        public Object Detail { get; set; }
    }


    public class bol_API_NotiDetailV2
    {
        public string CustAccNo { get; set; }
        public string BillInvoiceNo { get; set; }
        public string BillMonth { get; set; }
        public string Type { get; set; }
        public string Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionDate { get; set; }
        public string CurrencyAlias { get; set; }
    }

    public class bol_NotiListReqModelV2
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string DeviceID { get; set; }
        public string OriginLocationRFF { get; set; }
    }

    public class bol_API_SDFNOTI
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string AppID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string BodyDetail { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string InfoImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
