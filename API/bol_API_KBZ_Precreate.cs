using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_KBZ_Precreate
    {
        public int ActionParam { get; set; }

        public bol_API_KBZ_Precreate_Request Request { get; set; }

        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string BillInvoiceNo { get; set; }
        public string PaymentAlias { get; set; }
        public DateTime CreatedDate { get; set; }
        public string response_result { get; set; }
        public string response_message { get; set; }
        public string response_prepay_id { get; set; }
        public string response_nonce_str { get; set; }
        public string response_sign { get; set; }
        public string response_qrCode { get; set; }

        //public string BillMonth { get; set; }       //NSL bill month 1/10
    }

    public class bol_API_KBZ_PrecreateV2
    {
        public int ActionParam { get; set; }

        public bol_API_KBZ_Precreate_Request Request { get; set; }

        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string BillInvoiceNo { get; set; }
        public string PaymentAlias { get; set; }
        public DateTime CreatedDate { get; set; }
        public string response_result { get; set; }
        public string response_message { get; set; }
        public string response_prepay_id { get; set; }
        public string response_nonce_str { get; set; }
        public string response_sign { get; set; }
        public string response_qrCode { get; set; }

        public string BillMonth { get; set; }

        public string PXType { get; set; }      //Prepaid Enhancement

        public string DocumentAlias { get; set; }
        public string ReceivableChannelAlias { get; set; }
        public string PaymentSource { get; set; }
        public string PaymentOperator { get; set; }
        public string InternetRefNo { get; set; }
        public string CRNo { get; set; }
        public string merch_order_id { get; set; }

        //Evo
        public string CustCode { get; set; }
        public string Account { get; set; }
        public string OfferCode { get; set; }
        public string subsID { get; set; }
        public string effType { get; set; }
        public string billType { get; set; }
    }   

    public class bol_API_KBZ_Precreate_Request
    {
        public string timestamp { get; set; }
        public string method { get; set; }
        public string notify_url { get; set; }
        public string nonce_str { get; set; }
        public string sign_type { get; set; }
        public string sign { get; set; }
        public string version { get; set; }
        public bol_API_Precreate_biz_content biz_content { get; set; }

    }

    public class bol_API_Precreate_biz_content
    {
        public string merch_order_id { get; set; }
        public string merch_code { get; set; }
        public string appid { get; set; }
        public string trade_type { get; set; }
        public string title { get; set; }           //Optional
        public string total_amount { get; set; }
        public string trans_currency { get; set; }
        public string timeout_express { get; set; } //Optional  (120 minutes is used by default)
        public string callback_info { get; set; }   //Optional
        public string operator_id { get; set; }     //Optional
        public string store_id { get; set; }        //Optional
        public string terminal_id { get; set; }     //Optional
        public string business_param { get; set; }  //Optional
    }

    public class bol_API_KBZ_Precreate_Check
    {
        public int ActionParam { get; set; }
        public string BillInvoiceNo { get; set; }
        public int Counts { get; set; }
    }

    public class bol_API_Evo_KBZ_Precreate
    {
        public int ActionParam { get; set; }

        public bol_API_KBZ_Precreate_Request Request { get; set; }

        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string BillInvoiceNo { get; set; }
        public string PaymentAlias { get; set; }
        public DateTime CreatedDate { get; set; }
        public string response_result { get; set; }
        public string response_message { get; set; }
        public string response_prepay_id { get; set; }
        public string response_nonce_str { get; set; }
        public string response_sign { get; set; }
        public string response_qrCode { get; set; }

        public string BillMonth { get; set; }

        public string PXType { get; set; }      //Prepaid Enhancement

        public string DocumentAlias { get; set; }
        public string ReceivableChannelAlias { get; set; }
        public string PaymentSource { get; set; }
        public string PaymentOperator { get; set; }
        public string InternetRefNo { get; set; }
        public string CRNo { get; set; }
        public string merch_order_id { get; set; }

        public string CustCode { get; set; }
        public string Account { get; set; }
        public string OfferCode { get; set; }
        public string PWAURL { get; set; }

        public string subsID { get; set; }
        public string effType { get; set; }
        public string billType { get; set; }
    }

    public class bol_API_Evo_KBZ_Precreate_Check
    {
        public int ActionParam { get; set; }
        public string BillInvoiceNo { get; set; }
        public int Counts { get; set; }
    }

}
