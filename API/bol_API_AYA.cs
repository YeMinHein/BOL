using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_AYA
    {
        
    }

    public class bol_API_AYAToken
    {
        public int ActionParam { get; set; }
        public string token { get; set; }
    }

    public class bol_API_AYA_requestPushPayment
    {
        public int ActionParam { get; set; }
        public string customerPhone { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public string externalTransactionId { get; set; }
        public string externalAdditionalData { get; set; }
        public string serviceCode { get; set; }

        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string BillInvoiceNo { get; set; }
        public string TradeType { get; set; }
        public string Title { get; set; }
        public string PaymentAlias { get; set; }
        public string BillMonth { get; set; }
        public string PaymentType { get; set; }

        public string PXType { get; set; }

        public string responseReferenceNumber { get; set; }
        public string responseQRData { get; set; }
    }

    public class bol_API_AYA_PayRequestLog
    {
        public int ActionParam { get; set; }
        public string externalTransactionId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string RequestJSON { get; set; }
    }

    public class bol_API_AYA_Callback
    {
        public int ActionParam { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string currency { get; set; }
        public int fees_debitFee { get; set; }
        public int fees_creditFee { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public string transRefId { get; set; }
        public string code { get; set; }
        public string extMachId { get; set; }
        public string externalTransactionId { get; set; }
        public string referenceNumber { get; set; }
        public int totalAmount { get; set; }
        public int amount { get; set; }
        public string externalAdditionalData { get; set; }
        public string customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_phone { get; set; }
        public string merchant_id { get; set; }
        public string merchant_name { get; set; }
        public string merchant_phone { get; set; }
        public string checksum { get; set; }
        public string paymentResult { get; set; }
        public string refundResult { get; set; }
    }

    public class bol_API_AYA_Callback_Log
    {
        public int ActionParam { get; set; }
        public string checksum { get; set; }
        public string paymentResult { get; set; }
        public string refundResult { get; set; }
    }

    public class API_AYA_Callback
    {
        public string name { get; set; }
        public string desc { get; set; }
        public string currency { get; set; }
        public int fees_debitFee { get; set; }
        public int fees_creditFee { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public string transRefId { get; set; }
        public string code { get; set; }
        public string extMachId { get; set; }
        public string externalTransactionId { get; set; }
        public string referenceNumber { get; set; }
        public int totalAmount { get; set; }
        public int amount { get; set; }
        public string externalAdditionalData { get; set; }
        public string customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_phone { get; set; }
        //public string merchant_id { get; set; }
        //public string merchant_name { get; set; }
        //public string merchant_phone { get; set; }
        //public string checksum { get; set; }
        //public string paymentResult { get; set; }
        //public string refundResult { get; set; }
    }


}
