using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_Log
    {

    }

    public class bol_API_BELog
    {
       public int ActionParam { get; set; }
       public string URL { get; set; }
       public string AppID { get; set; }
       public string Request { get; set; } 
       public string Response { get; set; }
    }

    public class bol_API_PILog
    {
        public int ActionParam { get; set; }
        public string URL { get; set; }
        public string AppID { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }

    public class bol_API_CheckTxnLog
    {
        public int ActionParam { get; set; }
        public string BillInvoiceNo { get; set; }
        public string DocumentAlias { get; set; }
        public int Counts { get; set; }
    }

    public class bol_API_TxnLog
    {
        public int ActionParam { get; set; }
        public string BillingAccountNo { get; set; }
        public string BillInvoiceNo { get; set; }
        public double? TransactionAmount { get; set; }
        public string DocumentAlias { get; set; }
        public string ReceivableChannelAlias { get; set; }
        public string PaymentSource { get; set; }
        public string PaymentOperator { get; set; }
        public string InternetRefNo { get; set; }
        public string CRNo { get; set; }
        public string CurrencyAlias { get; set; }
        public string merch_order_id { get; set; }
        public string BillMonth { get; set; }
        public string OrderCode { get; set; }
        public int PromoPlanID { get; set; }
    }

    public class bol_API_HistoryLog
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string UserAgent { get; set; }
        public bool IsBOT { get; set; }
        public bool IsCrawler { get; set; }
        public string Browser { get; set; }
        public string IPAddress { get; set; }
        public string Device { get; set; }
        public string Platform { get; set; }
        public string Website { get; set; }     //API
        public DateTime CreatedDate { get; set; }
    }

    public class bol_API_AdvPayHistoryLog
    {
        public int ActionParam { get; set; }
        public int SA_ID { get; set; }
        public string OrderCode { get; set; }
        public string merch_order_id { get; set; }
        public string prepay_id { get; set; }
        public string PaymentOperator { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentAlias { get; set; }

        public string Bank { get; set; }
    }

    public class bol_API_RechargeTxnLog
    {
        public int ActionParam { get; set; }
        public string BillingAccountNo { get; set; }
        public string BillInvoiceNo { get; set; }
        public double? TransactionAmount { get; set; }
        public string DocumentAlias { get; set; }
        public string ReceivableChannelAlias { get; set; }
        public string PaymentSource { get; set; }
        public string PaymentOperator { get; set; }
        public string InternetRefNo { get; set; }
        public string CRNo { get; set; }
        public string CurrencyAlias { get; set; }
        public string merch_order_id { get; set; }
        public string BillMonth { get; set; }

        public string DDNo { get; set; }
        public string packageId { get; set; }
        public string rechargePackageName { get; set; }
        public double denominationAmount { get; set; }
        public int creditLimit { get; set; }
        public DateTime expiryDate { get; set; }
        public string limitType { get; set; }
        public double quota { get; set; }
        public string rechargeRequestNo { get; set; }

        public DataTable Detail { get; set; }
    }

    public class bol_API_PaymentQueryOrder
    {
        public int ActionParam { get; set; }
        public string orderCode { get; set; }
        public string transactionID { get; set; }
        public string billingAccountNo { get; set; }
        public string billInvoiceNo { get; set; }
        public double? transactionAmount { get; set; }
        public string documentAlias { get; set; }
        public string receivableChannelAlias { get; set; }
        public string paymentSource { get; set; }
        public string paymentOperator { get; set; }
        public string internetRefNo { get; set; }
        //public string CRNo { get; set; }
        public string currencyAlias { get; set; }
        public string merch_order_id { get; set; }
        public string billMonth { get; set; }
        public int promoPlanID { get; set; }
    }

    public class bol_API_PrepaidAmendLog
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public string UserName { get; set; }
        public string Type { get; set; }
    }

    public class bol_API_PrepaidActivityLog
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public bool IsWithinMinute { get; set; }
        public string CreatedBy { get; set; }
    }

    public class bol_API_PXSyncData
    {
        public int ActionParam { get; set; }
        public string CreatedBy { get; set; }
        public string customerAccountNumber { get; set; }
        public DataTable udt_PXSyncData { get; set; }
        //public string transactionNumber { get; set; }
        //public string date { get; set; }
        //public string paymentMode { get; set; }
        //public string amount { get; set; }
        //public string paymentStatus { get; set; }
        //public string currencyName { get; set; }
        //public string channelAlias { get; set; }
        //public string creditDocumentNumber { get; set; }
    }
}
