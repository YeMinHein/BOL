using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_Firebase
    {

        [Required(ErrorMessage = "serviceaccountname is required")]
        [MinLength(3, ErrorMessage = "serviceaccountname be at least 3 characters long.")]
        public string serviceaccountname { get; set; }
     //   [MinLength(3, ErrorMessage = "fcmendpoints must be at least 3 characters long.")]
      //  public string fcmendpoints { get; set; }
        public List<string> deviceTokens { get; set; }
        public string topicname { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters long.")]
        public string title { get; set; }

        [Required(ErrorMessage = "appName is required")]
        [MinLength(3, ErrorMessage = "appName must be at least 3 characters long.")]
        public string appName { get; set; }

        [Required(ErrorMessage = "Body is required")]
        [MinLength(3, ErrorMessage = "Body must be at least 3 characters long.")]
        public string body { get; set; }
        public object data { get; set; }
        public string icon { get; set; }

    }


    public class bol_Topic_API_Firebase
    {
        [Required(ErrorMessage = "topic type is required")]
        [MinLength(3, ErrorMessage = "topic type be at least 3 characters long.")]
        public string topictype { get; set; }

        [Required(ErrorMessage = "topic  is required")]
        [MinLength(3, ErrorMessage = "topic  be at least 3 characters long.")]
        public string topic { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters long.")]
        public string title { get; set; }

        [Required(ErrorMessage = "Body is required")]
        [MinLength(3, ErrorMessage = "Body must be at least 3 characters long.")]
        public string body { get; set; }

        public int templateID { get; set; }
        public bool showInInbox { get; set; }
        public string createdby { get; set; }
        public int notiID { get; set; }

    }

    public class bol_Evo_Noti_Device
    {
        [Required(ErrorMessage = "Event type is required")]
        [MinLength(5, ErrorMessage = "Event type be at least 5 characters long.")]
        public string event_type { get; set; }

        [Required(ErrorMessage = "Created By is required")]
        [MinLength(5, ErrorMessage = "Created By be at least 5 characters long.")]
        public string createdBy { get; set; }

        public int datacount { get; set; }

        //[Required(ErrorMessage = "Data is required")]
        //public dynamic data { get; set; }

        public int notisendId { get; set; }

    }


    public class bol_Evo_Noti_Send_Req_Model
    {
        [Required(ErrorMessage = "Event type is required")]
        [MinLength(5, ErrorMessage = "Event type be at least 5 characters long.")]
        public string event_type { get; set; }

        //[Required(ErrorMessage = "Data is required")]
        //public dynamic data { get; set; }

        [Required(ErrorMessage = "Data List is required")]
        public List<dynamic> data { get; set; }

        public int notisendId { get; set; }

    }

    public class bol_API_Firebase_SubscribeTopic
    {
        [Required(ErrorMessage = "serviceaccountname is required")]
        [MinLength(3, ErrorMessage = "serviceaccountname be at least 3 characters long.")]
        public string serviceaccountname { get; set; }
        //   [MinLength(3, ErrorMessage = "fcmendpoints must be at least 3 characters long.")]
        //  public string fcmendpoints { get; set; }
        [Required(ErrorMessage = "Device Token  is required")]
        [MinLength(3, ErrorMessage = "Device Token must be at least 3 characters long.")]
        public string deviceToken { get; set; }

        [Required(ErrorMessage = "appName is required")]
        [MinLength(3, ErrorMessage = "appName must be at least 3 characters long.")]
        public string appName { get; set; }
        public List<string> topicLists { get; set; }

    }

    public class Evo_FirebaseTopicReqModel
    {
        public int ActionParam { get; set; }

        [Required(ErrorMessage = "CustomerCode is required")]

        [MinLength(5, ErrorMessage = "CustomerCode be at least 5 characters long.")]
        public string CustomerCode { get; set; }

        [Required(ErrorMessage = "Token is required")]
        [MinLength(3, ErrorMessage = "Token be at least 3 characters long.")]
        public string Token { get; set; }

        [Required(ErrorMessage = "AppVersion is required")]
        [MinLength(3, ErrorMessage = "AppVersion be at least 3 characters long.")]
        public string AppVersion { get; set; }

        [Required(ErrorMessage = "Platform is required")]
        [MinLength(3, ErrorMessage = "Platform be at least 3 characters long.")]
        public string Platform { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [MinLength(3, ErrorMessage = "Model be at least 3 characters long.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "DeviceVersion is required")]
        [MinLength(3, ErrorMessage = "DeviceVersion be at least 3 characters long.")]
        public string DeviceVersion { get; set; }
    }

    public class Evo_SearchCustomerPrimaryReqModel
    {
        [Required(ErrorMessage = "Customer Code is required")]
        [MinLength(5, ErrorMessage = "Customer Code be at least 5 characters long.")]
        public string custCode { get; set; }

        [Required(ErrorMessage = "Service No is required")]
        [MinLength(5, ErrorMessage = "Service No be at least 5 characters long.")]
        public string serviceno { get; set; }
    }

    public class Evo_TokenList_ReqModel
    {
        public string CustomerCode { get; set; }
        public string ServiceNo { get; set; }
    }
    public class Evo_TokenList_ResponseModel
    {
        public string Token { get; set; }
        public string CustomerCode { get; set; }
    }

    public class Evo_SubscriberPrimary
    {
        public string CustCode { get; set; }
        public string ServiceNo { get; set; }
        public string AcctNbr { get; set; }
        //public string ProdState { get; set; }
        //public string ServiceStatus { get; set; }
        public bool IsPrimary { get; set; }
    }


    public class Evo_SubscriberCreatedDateNull
    {
        public string CustCode { get; set; }
    }

    public class Evo_Noti
    {
        [Required(ErrorMessage = "Event type is required")]
        [MinLength(5, ErrorMessage = "Event type be at least 5 characters long.")]
        public string event_type { get; set; }

        //[Required(ErrorMessage = "Data is required")]
        //public dynamic data { get; set; }

        [Required(ErrorMessage = "Data List is required")]
        public List<dynamic> data { get; set; }

        public int notisendId { get; set; }

    }


    public class Evo_Noti_Device
    {
        [Required(ErrorMessage = "Event type is required")]
        [MinLength(5, ErrorMessage = "Event type be at least 5 characters long.")]
        public string event_type { get; set; }

        [Required(ErrorMessage = "Created By is required")]
        [MinLength(5, ErrorMessage = "Created By be at least 5 characters long.")]
        public string createdBy { get; set; }

        public int datacount { get; set; }

        //[Required(ErrorMessage = "Data is required")]
        //public dynamic data { get; set; }

        public int notisendId { get; set; }

    }

    public class bol_Evo_NOTI_Send
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Type { get; set; }
        public string? SubType { get; set; }
        public string? TemplateID { get; set; }
        public string? TopicType { get; set; }
        public string? Topic { get; set; }
        public string? Category { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public bool showInInbox { get; set; }
        public int Records { get; set; }
    }

    public class Evo_Noti_Data_Model
    {
        public string Customer_Name { get; set; }
        public string Customer_Code { get; set; }
        public string Service_Number { get; set; }
        public string Title { get; set; }
        public string Full_Installation_Address { get; set; }


        public string New_Package_Name { get; set; }
        public string Old_Package_Name { get; set; }
        public string Status_Name { get; set; }


        public string Remaining_Value { get; set; }
        public string Subscription_Plan { get; set; }
        public string Package_Name { get; set; }

        
        public string Expiry_Date { get; set; }


        public string Old_Data { get; set; }
        public string New_Data { get; set; }

        public string Password { get; set; }


        public string DueDate { get; set; }
        public string Account_Number { get; set; }


        public string Receipt_Number { get; set; }
        public string Payment_Amount { get; set; }

        public string INV_Number { get; set; }
        public string Payment_Status { get; set; }
        public string Status { get; set; }
        public string Unpaid_Amount { get; set; }

        public string Advance_Balance_Amount { get; set; }

    }

    public class bol_Evo_NOTI_SendDevice
    {
        public int ActionParam { get; set; }
        public int NotiSendID { get; set; }
        public string CustomerCode { get; set; }
        public string ServiceNo { get; set; }
        public string DeviceID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string BodyDetail { get; set; }
        public string merch_order_id { get; set; }
        public string mm_order_id { get; set; }
        public string PaymentOperator { get; set; }

      
        public string SentDate { get; set; }

        public int TemplateID { get; set; }

        public int SubType { get; set; }
        public string InfoImageUrl { get; set; }

    }

    public class Evo_Noti_List_Req_Model
    {
        [Required(ErrorMessage = "CustomerCode is required")]

        [MinLength(5, ErrorMessage = "CustomerCode be at least 5 characters long.")]
        public string CustomerCode { get; set; }
    }

    public class Evo_Noti_Update_ReqModel
    {
        [Required(ErrorMessage = "ID is required")]
        //[Range(1, int.MaxValue, ErrorMessage = "ID must be greater than 0")]
        public List<int> ID { get; set; }

        [Required(ErrorMessage = "CustomerCode is required")]

        [MinLength(5, ErrorMessage = "CustomerCode be at least 5 characters long.")]
        public string CustomerCode { get; set; }
    }

    public class Evo_Noti_Detail_ReqModel
    {
        [Required(ErrorMessage = "ID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "ID must be greater than 0")]
        public int ID { get; set; }

        [Required(ErrorMessage = "CustomerCode is required")]

        [MinLength(5, ErrorMessage = "CustomerCode be at least 5 characters long.")]
        public string CustomerCode { get; set; }
    }
    public class Evo_Noti_List_Response_Model
    {
        public int ID { get; set; }
        public string CustomerCode { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string BodyDetail { get; set; }
        public bool IsRead { get; set; }
        public bool IsEnableDelete { get; set; }
        public string CreatedDate { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Category { get; set; }
        public int sortOrder { get; set; }
        public string InfoImageUrl { get; set; }
        public string PromoImageUrl { get; set; }
        public string PromoUrl { get; set; }
        public bool IsDefault { get; set; }

        [JsonIgnore]
        public string Details { get; set; }

        [JsonIgnore]
        public string merch_order_id { get; set; }
        public EvoNotiDetail Detail { get; set; }

        // public dynamic Detail { get; set; }

        // Raw Detail string returned from DB
    }

    public class EvoNotiDetail
    {
        public string CustomerCode { get; set; }
        public string ServiceNo { get; set; }
        public string BillInvoiceNo { get; set; }
        public string BillMonth { get; set; }
        public string Type { get; set; }
        public string Amount { get; set; }
        public string PaymentMethod{get;set;}
        public string TransactionDate { get; set; }
        public string CurrencyAlias { get; set; }
    }
    public class Evo_Noti_Detail_Response_Model
    {
        public int ID { get; set; }
        public string CustomerCode { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string BodyDetail { get; set; }
    }
   }
