using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CNP
{
    public class bol_CNP_Subscription
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? CustAccNo { get; set; }

        public string? FormattedCreatedDate { get; set; }
        public string? FormattedSolvedDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public string? SearchText { get; set; }
    }

    public class bol_CNP_CustomerRequestModel
    {
        public int ActionParam { get; set; }
        public string CustomerAccNo { get; set; }
        public string CustomerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string RegisteredMobileNo { get; set; }
        public string MobileNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
    public class bol_CNP_CustomerResponseModel
    {
        public string RespCode { get; set; }
        public string RespDescription { get; set; }
        public int CNP_id { get; set; }
    }

    #region Subscritpion
    public class bol_CNP_SubscritpionRequestModel
    {
        public string ActionParam { get; set; }
        public int CNP_id { get; set; }
        public string CustomerAccNo { get; set; }
        public string ServicePlan { get; set; }
        public string BasePlan { get; set; }
        public DateTime SubscribedStartDate { get; set; }
        public DateTime SubscribedEndDate { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Totaldays { get; set; }
        public int Price { get; set; }
        public Boolean IsOverride { get; set; }
        public int OverridePrice { get; set; }
        public Boolean IsPromo { get; set; }
        public int PromoID { get; set; }
        public bool Downloaded { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SubId { get; set; }
    }
    public class bol_CNP_SubscritpionResponseModel
    {
        public string RespCode { get; set; }
        public string RespDescription { get; set; }
        public int SubId { get; set; }
        public string CustomerAccNo { get; set; }
        public DateTime SubscribedStartDate { get; set; }
        public DateTime SubscribedEndDate { get; set; }
        public string StrSubscribedStartDate { get; set; }
        public string StrSubscribedEndDate { get; set; }
        public int Totaldays { get; set; }
        public int LastDate { get; set; }
        public Boolean IsPromo { get; set; }
        public int PromoID { get; set; }
        public int OverridePrice { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class bol_CNP_CanalPlusSubscriptionRequestModel
    {
        public int ActionParam { get; set; }
        public string CustomerAccNo { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int CNP_id { get; set; }
        public string ServicePlan { get; set; }
        public string BasePlan { get; set; }
        public string SubscribedStartDate { get; set; }
        public string SubscribedEndDate { get; set; }
        public string Type { get; set; }
        public int Totaldays { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean IsOverride { get; set; }
        public int OverridePrice { get; set; }
        public Boolean IsPromo { get; set; }
        public int PromoID { get; set; }
        public bool Downloaded { get; set; }
    }


    #endregion Subscritpion

    public class bol_CNP_ServiceInstanceDetailsRespModel
    {
        public int ActionParam { get; set; }
        public string ServiceInstanceNo { get; set; }
        public string ServiceAccountNo { get; set; }
        public string CustomerAccountNo { get; set; }
        public string Name { get; set; }
        public string ServicePlanName { get; set; }
        public string MainPlan { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public Decimal Price { get; set; }
        public string SafeCustody { get; set; }
        public string UserID { get; set; }
        public string CustomerType { get; set; }
        public string BillingStatus { get; set; }
        public string DunningExcluded { get; set; }
        public string CurrencyID { get; set; }
        public string LeafNode { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string Password { get; set; }
        public string PromoName { get; set; }
        public string PromoStartDate { get; set; }
        public string PromoEndDate { get; set; }
        public string serviceInstanceNo { get; set; }
        public string ExpiryDate { get; set; }
    }

    public class bol_CNP_CustomerAccDetailRequestModel
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string CreationDate { get; set; }
        public string Status { get; set; }
        public string EmailAddress { get; set; }
        public string RegisteredMobileNo { get; set; }
        public string BillingArea { get; set; }
        public string CustomerCategory { get; set; }
        public string GEOld { get; set; }
        public string UserName { get; set; }
        public string PartnerAccNumber { get; set; }
        public string OrganizationID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
        public string MobileNumber { get; set; }
        public string CanalPlusPhoneNo { get; set; }
        public string MultipleMobileNumber { get; set; }
        public string CustomerAccNumberID { get; set; }
        public string BillAddCompanyName { get; set; }
        public string RegNo { get; set; }
        public string BusinessType { get; set; }
        public string ICO { get; set; }
        public string LeadID { get; set; }
        public int CAFNumber { get; set; }
        public string CAFFormNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string MultipleEmailID { get; set; }
        public string ConnectionType { get; set; }
        public decimal ActualAmount { get; set; }
        public int PromoID { get; set; }
        public decimal OverridenAmount { get; set; }
        public int IONumber { get; set; }
    }

    public class bol_CNP_PolicyModel
    {
        public string RespCode { get; set; }
        public string RespDescription { get; set; }
        public int subscriptionDays { get; set; }
        public int PolicyID { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDescription { get; set; }
        public string CustomerType { get; set; }
        public string PlanName { get; set; }
        public int FreeDays { get; set; }
        public int CostPerMonth { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int TotalCost { get; set; }
        public DateTime PromoStartDate { get; set; }
        public DateTime PromoEndDate { get; set; }
        public string PromoName { get; set; }
        public int PPid { get; set; }
    }

    public class bol_CNP_ServicePlanModel
    {
        public int ServicePlanID { get; set; }
        public int ID { get; set; }
        public string PlanName { get; set; }
        public string Description { get; set; }
        public int OrderNo { get; set; }
    }
}
