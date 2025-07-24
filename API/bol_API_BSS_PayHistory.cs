using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_BSS_PayHistory
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string CustomerAccountNo { get; set; }
        public string? BillingAccountNo { get; set; }
        public double? TransactionAmount { get; set; }
        public string DocumentAlias { get; set; }
        public string CurrencyAlias { get; set; }
        public string ChannelAlias { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentDocumentNo { get; set; }
        public int? CreditDocumentID { get; set; }
        public string RefNumber { get; set; }
        public string InstituteMaster { get; set; }
        public string Remark { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string BillInvoiceNo { get; set; }

        public bool MultiFlag { get; set; }
        public double? TotalAmount { get; set; }
    }
}
