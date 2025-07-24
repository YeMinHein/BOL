using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.PAY
{
    public class bol_PAY_Refund
    {
        public int ActionParam { get; set; }
        public int SA_ID { get; set; }
        public bool IsSyncBSS { get; set; }
        public string merch_order_id { get; set; }
        public string OrderCode { get; set; }
        public string PaymentType { get; set; }
        public string PromoName { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentOperator { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedDateStr { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentAlias { get; set; }
        public string transaction_id { get; set; }
        public string PlanName { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentDateStr { get; set; }
        public string UpdatePaymentStatus { get; set; }
        public string LastStatusName { get; set; }
        public string LastStatus { get; set; }
        public string customerAccountNo { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string NRC { get; set; }
        public double TotalAmount { get; set; }
        public string BillInvoiceNo { get; set; }
        public bool Is_Refund { get; set; }
        public string Refund_Remark { get; set; }
        public string billingArea { get; set; }
        public DateTime Refund_Date { get; set; }
        public string Refund_By { get; set; }
        public string OrderCancelledBy { get; set; }
        public DateTime OrderCancelledDate { get; set; }
    }
}
