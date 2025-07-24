using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_Evo_EOD
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

    public class bol_API_KBZ_EMoneyPayments
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
        public string IsSyncBSS { get; set; }

        public bol_API_KBZ_EMoneyPaymentDetail detail { get; set; }

        public int PaymentCounts { get; set; }
    }

    public class bol_API_KBZ_EMoneyPaymentDetail
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

    public class Evo_RetrieveEMoneyPayment_ReqModel
    {
        public string EncData { get; set; }
    }
    public class bol_API_EvoEODProgress
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

    public class bol_API_EvoGetEODDtailList
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
}
