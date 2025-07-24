using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_CB
    {
    }
    public class bol_API_CB_CallBack
    {
        public int ActionParam { get; set; }
        public string generateRefOrder { get; set; }
        public string transactionId { get; set; }
        public string transactionDateTime { get; set; }
        public string ecommerceId { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public string feeAmount { get; set; }
        public string discount { get; set; }
        public string totalAmount { get; set; }
        public string signature { get; set; }
        public string transactionStatus { get; set; }
        public string responseCode { get; set; }
        public string responseMsg { get; set; }

    }

    public class bol_API_CB_RequestPaymentOrderService
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string BillInvoiceNo { get; set; }
        public string Title { get; set; }
        public string TradeType { get; set; }
        public string PaymentAlias { get; set; }


        public string authenToken { get; set; }
        public string ecommerceId { get; set; }
        public string transactionType { get; set; }
        public string orderId { get; set; }
        public string orderDetails { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
        public string notifyUrl { get; set; }
        public string signature { get; set; }
        public string subMerId { get; set; }

    }

    public class bol_API_CB_RequestPaymentOrderLog
    {
        public int ActionParam { get; set; }
        public string orderId { get; set; }
        public string generateRefOrder { get; set; }
        public string code { get; set; }
        public string msg { get; set; }
        public string Status { get; set; }
        public string RequestJSON { get; set; }
    }
}
