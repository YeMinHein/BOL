using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_WM
    {
        public int ActionParam { get; set; }
        public string merchant_id { get; set; }
        public string order_id { get; set; }
        public string merchant_reference_id { get; set; }
        public string frontend_result_url { get; set; }
        public string backend_result_url { get; set; }
        public int amount { get; set; }
        public int time_to_live_in_seconds { get; set; }
        public string payment_description { get; set; }
        public string merchant_name { get; set; }
        public string items { get; set; }
        public string hash { get; set; }
        public string response_message { get; set; }
        public string response_transaction_id { get; set; }

        public bol_API_WM_Detail detail { get; set; }

        public string PaymentAlias { get; set; }
    }
    public class bol_API_WM_Detail
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
    }

    public class bol_API_WM_CallBack
    {
        public int ActionParam { get; set; }
        public string status { get; set; }
        public string merchantId { get; set; }
        public string orderId { get; set; }
        public string merchantReferenceId { get; set; }
        public string frontendResultUrl { get; set; }
        public string backendResultUrl { get; set; }
        public string initiatorMsisdn { get; set; }
        public int amount { get; set; }
        public int timeToLiveSeconds { get; set; }
        public string paymentDescription { get; set; }
        public string currency { get; set; }
        public string hashValue { get; set; }
        public string additionalField1 { get; set; }
        public string additionalField2 { get; set; }
        public string additionalField3 { get; set; }
        public string additionalField4 { get; set; }
        public string additionalField5 { get; set; }
        public string transactionId { get; set; }
        public string paymentRequestId { get; set; }
        public DateTime requestTime { get; set; }

    }

    public class bol_API_WM_PayRequestLog
    {
        public int ActionParam { get; set; }
        public string merchant_reference_id { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string RequestJSON { get; set; }
    }

    public class bol_API_WM_PayRequestLogV2
    {
        public int ActionParam { get; set; }
        public string merchant_reference_id { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string RequestJSON { get; set; }
        public string GTG_RequestJSON { get; set; }
    }

    #region Evo
    public class bol_API_Evo_WM
    {
        public int ActionParam { get; set; }
        public string merchant_id { get; set; }
        public string order_id { get; set; }
        public string merchant_reference_id { get; set; }
        public string frontend_result_url { get; set; }
        public string backend_result_url { get; set; }
        public int amount { get; set; }
        public int time_to_live_in_seconds { get; set; }
        public string payment_description { get; set; }
        public string merchant_name { get; set; }
        public string items { get; set; }
        public string hash { get; set; }
        public string response_message { get; set; }
        public string response_transaction_id { get; set; }
        public string PaymentAlias { get; set; }
        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string BillInvoiceNo { get; set; }
        public string TradeType { get; set; }
        public string BillMonth { get; set; }
        public string PaymentType { get; set; }
        public string PXType { get; set; }      //Prepaid Enhancement 
        public string CustCode { get; set; }
        public string Account { get; set; }
        public string OfferCode { get; set; }
        public string subsID { get; set; }
        public string effType { get; set; }
        public string billType { get; set; }
        public string Title { get; set; }


    }
    #endregion
}
