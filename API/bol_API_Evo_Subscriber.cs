using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
   public class bol_API_Evo_Subscriber
    {
        public int ActionParam { get; set; }
        public string CustCode { get; set; }
        public string CustomerName { get; set; }
        public string AcctNbr { get; set; }
        public string ServiceNo_AccNbr { get; set; }
        public string EvoCreatedDate { get; set; }
        public string SubName { get; set; }
        public string SubsID { get; set; }
        public string OfferCode { get; set; }
        public string ServiceType { get; set; }
        public string PaidFlag { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Township { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string SubAddress { get; set; }
        public string ServiceStatus { get; set; }
        public string ProdState { get; set; }
        public string BlockReason { get; set; }
    }
    public class bol_API_Evo_PaymentSetting
    {
        public string ServiceType { get; set; }
        public string PaymentType { get; set; }
        public string PaymentMethod { get; set; }
        public bool IsOpen { get; set; }
    }
    public class bol_API_Evo_Application_Log
    {
        [Required(ErrorMessage = "CustomerCode is required.")]
        public string CustomerCode { get; set; }
        public string ErrorMessage { get; set; }
        public string CreatedDate { get; set; }
        public string APICode { get; set; }
        public string ResponseCode { get; set; }
        [Required(ErrorMessage = "FileName is required.")]
        public string FileName { get; set; }
        [Required(ErrorMessage = "MethodName is required.")]
        public string MethodName { get; set; }
    }
    public class bol_API_Evo_Application_Log_Search
    {
        [Required(ErrorMessage = "StartDate is required.")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "EndDate is required.")]
        public string EndDate { get; set; }

        public string CustomerCode { get; set; }
    }
}
