using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_KBZ_Transaction
    {
        public int ActionParam { get; set; }
        public string BillInvoiceNo { get; set; }
        public string merch_order_id { get; set; }
        public bool IsSyncBSS { get; set; }
        public int BankID { get; set; }
        public string BankName { get; set; }
        public char PartyTypeCode { get; set; }
        public string PartyType { get; set; }
        public int ContactChannelID { get; set; }
        public string ContactChannelName { get; set; }
        public int PaymentMethodID { get; set; }
        public string PaymentMethodName { get; set; }
        public int AcctResID { get; set; }
        public string AcctResName { get; set; }
        public string PartnerSn { get; set; }
        public string PartyCode { get; set; }
        public string msisdn { get; set; }
        public decimal Amount { get; set; }
        public string Voucher { get; set; }
        public string CheckNbr { get; set; }
        public string CheckOwnerName { get; set; }
        public DateTime? CheckIssueDate { get; set; }
        public DateTime? CheckExpDate { get; set; }
        public string vcpin { get; set; }
        public string Remarks { get; set; }
        public DateTime? ClearanceDate { get; set; }

        //Evo
        public string Name { get; set; }
        public string CustCode { get; set; }
        public string Account { get; set; }
        public string OfferCode { get; set; }
        public string BillMonth { get; set; }
        public string BatchPaymentID { get; set; }
        public string subsID { get; set; }
        public string billType { get; set; }
    }
}
