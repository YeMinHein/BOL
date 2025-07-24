using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_MCB
    {
    }
    public class bol_API_MCB_EMoneyPayments
    {
        public int ActionParam { get; set; }

        public string redirectUrl { get; set; }
        public string merchantPaymentRef { get; set; }
        public string order { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
        public string payerFsp { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string BillInvoiceNo { get; set; }
        public string TradeType { get; set; }
        public string Title { get; set; }
        public string PaymentAlias { get; set; }
        public string BillMonth { get; set; }
        public string PaymentType { get; set; }
        public string response_result { get; set; }
        public string response_message { get; set; }
        public string contextId { get; set; }
        public string merchantId { get; set; }

        public bol_API_MCB_EMoneyPaymentDetail detail { get; set; }

        public int PaymentCounts { get; set; }
    }

    public class bol_API_MCB_EMoneyPaymentDetail
    {
        public string contextId { get; set; }
        public string merchantId { get; set; }
        public string paymentGatewayUrl { get; set; }
        public string redirectUrl { get; set; }
        public string contextStatus { get; set; }
        public string payerFsp { get; set; }
        public string payerId { get; set; }
        public string transactionRef { get; set; }
        public DateTime transactionTimestamp { get; set; }
        public string payerFspTransactionRef { get; set; }
        public string payerFspTransactionTimestamp { get; set; }
        public DateTime createTime { get; set; }
        public DateTime expiryTime { get; set; }
        public string createTimeUnix { get; set; }
        public string expiryTimeUnix { get; set; }
    }

    public class bol_API_MCB_EOD
    {
        public int ActionParam { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Records { get; set; }

        public int EODID { get; set; }
        public string merchantPaymentRef { get; set; }
        public string contextStatus { get; set; }
        public string PaymentOperator { get; set; }
    }


    public class bol_API_MCBEODProgress
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public int? Records { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ProgressRecords { get; set; }
        public int? CompleteRecords { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string? FormattedCreatedDate { get; set; }
        public string? FormattedCompletedDate { get; set; }
        public string? EODStartDate { get; set; }
        public string? EODEndDate { get; set; }
    }

    public class bol_API_MCBGetEODDtailList
    {
        public int ActionParam { get; set; }
        public string? SearchText { get; set; }
        public int EODID { get; set; }
        public string merchantPaymentRef { get; set; }
        public string payerId { get; set; }
        public string preContextStatus { get; set; }
        public string contextStatus { get; set; }
        public string transactionRef { get; set; }
        public bool IsSyncBSS { get; set; }
        public string FormattedCreatedDate { get; set; }

        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public double amount { get; set; }
        public string BillInvoiceNo { get; set; }

        public int PageIndex { get; set; }

    }

    public class bol_API_GetEODList
    {
        public int ActionParam { get; set; }
        public string? SearchText { get; set; }
        public string PaymentOperator { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public int ID { get; set; }
        public string FormattedStartDate { get; set; }
        public string FormattedEndDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public string FormattedCompletedDate { get; set; }
        public int Records { get; set; }
        public int UpdateRecords { get; set; }

        public int PageIndex { get; set; }

    }


    public class bol_API_MCB_PaymentStep1PG
    {
        public int ActionParam { get; set; }
        //public bol_API_MCB_PaymentStep1PG_toUser toUser { get; set; }
        public string userIdentifier { get; set; }
        public string serviceId { get; set; }
        public string productId { get; set; }
        public string remarks { get; set; }
        public string mpin { get; set; }
        public string orderId { get; set; }
        public string languageCode { get; set; }

        public int amount { get; set; }
        public int exponent { get; set; }
        public string currency { get; set; }
        public string unitType { get; set; }

        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public string responseTransactionID { get; set; }
        public string responseToken { get; set; }

        public string transactionId { get; set; }       //txn
        public string transactionCode { get; set; }     //txn

        //public DataTable payment { get; set; }
        //public List<bol_API_MCB_PaymentStep1PG_payment> payment { get; set; }

        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string BillInvoiceNo { get; set; }
        public string TradeType { get; set; }
        public string Title { get; set; }
        public string PaymentAlias { get; set; }
        public string BillMonth { get; set; }
        public string PaymentType { get; set; }

        public string order_id { get; set; }

        public string PXType { get; set; }      //Prepaid Enhancement 
    }
    //public class bol_API_MCB_PaymentStep1PG_toUser
    //{
    //    public string userIdentifier { get; set; }
    //}
    //public class bol_API_MCB_PaymentStep1PG_payment
    //{
    //    public int amount { get; set; }
    //    public int exponent { get; set; }
    //    public string currency { get; set; }
    //    public string unitType { get; set; }
    //}

    public class bol_API_MCB_PayRequestLog
    {
        public int ActionParam { get; set; }
        public string orderId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string RequestJSON { get; set; }
    }

    public class bol_API_MCB_Detail
    {
        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string BillInvoiceNo { get; set; }
        public string TradeType { get; set; }
        public string Title { get; set; }
        public string PaymentAlias { get; set; }
        public string BillMonth { get; set; }
        public string PaymentType { get; set; }

        public string PXType { get; set; }      //Prepaid Enhancement 

        public int amount { get; set; }
        public string currency { get; set; }

        public string transactionStatus { get; set; }
    }

}
