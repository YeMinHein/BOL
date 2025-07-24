using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_SAForm
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? DOB { get; set; }
        public string? NRCPassport { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyRegistrationNo { get; set; }
        public string? TypeOfBusiness { get; set; }
        public string? InstallationAddress { get; set; }
        public bool? IsCompany { get; set; }
        public int? CityID { get; set; }
        public int? TownshipID { get; set; }
        public string? EmailAddress { get; set; }
        public string? MobileNo { get; set; }
        public int? ServicePlanID { get; set; }
        public string? BankForPayment { get; set; }
        public string? ReferralCode { get; set; }
        public string? CreationDate { get; set; }
        public bool? isSentSMS { get; set; }
        public int? ServiceTypeID { get; set; }
        public int? AddOnID { get; set; }

        public bool? lstIsSolved { get; set; }
        public bool? IsSolved { get; set; }
        public DateTime? SolvedDate { get; set; }
        public string? SolvedBy { get; set; }
        public string? StaffRemark { get; set; }

        public string? FormattedCreatedDate { get; set; }
        public string? FormattedSolvedDate { get; set; }

        public string? City { get; set; }
        public string? Township { get; set; }
        public string? ServicePlan { get; set; }

        public string? SearchText { get; set; }
        public string? BillingArea { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int PageIndex { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int PromoPlanID { get; set; }
        public string OrderCode { get; set; }
        public string CityName { get; set; }
        public string? BuildingName { get; set; }
        public int? BuildingTypeID { get; set; }
       
        public string LastStatus { get; set; }
        public string LastLoggedBy { get; set; }
        public string Owner { get; set; }
        public string LastLoggedDate { get; set; }
        public bool? IsOnlyMe { get; set; }
        public int? LastStatusID { get; set; }
        // public int? LastChangeStatus_Setting_ID { get; set; }
        public string LastStatusParentName { get; set; }
        public string LastStatusName { get; set; }
        public string Status { get; set; }
        public string ColorCode { get; set; }
        public int? SuspendID { get; set; }
        public string StateAndDivision { get; set; }

        public string PromoName { get; set; }
        public double TotalCharges { get; set; }
        public double PlanAmount { get; set; }
        public double TaxAmount { get; set; }
        public double DepositAmount { get; set; }
        public bool? IsDeposit { get; set; }
        public int SurchargePercentage { get; set; }
        public string PaymentOperator {  get; set; }
        public string PaymentMethod { get; set; }
        public string Trade_Status { get; set; }
        public DateTime PaymentDate { get; set; }
        public string total_amount { get; set; }
        public string trans_currency { get; set; }
        public int LastGroupID { get; set; }
        public int LeadSourceID { get; set; }
        public string LeadSource { get; set; }
        public int ChannelID { get; set; }
        public string Channel { get; set; }
        public int FinanceUser { get; set; }
        public int IsSPSEngineer { get; set; }
        public bool IsDepartmentAdmin { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string Source { get; set; }
        public string ChargingPattern { get; set; }
        public string Category { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string ODSOwner { get; set; }
        public string ServicePlanName { get; set; }
        public string ReceiptNo { get; set; }
        public string ReceiptDate { get; set; }
        public string InvoiceNo { get; set; }
        public string LeadCode { get; set; }
        public int SearchGroupID { get; set; }
        public int SearchTeamID { get; set; }
        public string SearchOwner { get; set; }
        public string CusAccNo { get; set; }
        public string Old_CusAccNo { get; set; }
        public string SearchByDate { get; set; }
        public string SearchByServiceNoStatus { get; set; }
        public string CustCode { get; set; }
        public string EvoCreatedDate { get; set; }
    }

    public class bol_FTTH_StatusModel
    {
        public int ID { get; set; }
        public int GroupID { get; set; }
        public string Status { get; set; }
        public string StatusName { get; set; }
        public int ParentGroupID { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
        public bool IsSentEmail { get; set; }
        public int ActionParam { get; set; }
        public int RoleID { get; set; }
        public string ColorCode { get; set; }

    }
    public class bol_SA_FTTH_StatusModel
    {
        public int ID { get; set; }
        public int? ActionParam { get; set; }
        public string Remark { get; set; }
        public int Status_ID { get; set; }
        public int SA_ID { get; set; }
        public string LoggedBy { get; set; }
        public DateTime LoggedDate { get; set; }
        public string LoggedDateStr { get; set; }
        public int ParentGroupID { get; set; }
        public string Step { get; set; }
        public string StepStatus { get; set; }
        public string Status { get; set; }
        public string StatusName { get; set; }
        public string StatusColorCode { get; set; }
        public string Date { get; set; }
        public string OtherServiceName { get; set; }
        public string Channel { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string ServiceNo { get; set; }
        public string DurationFormatted { get; set; }
        //public string NewName { get; set; }
        //public string MobileNo { get; set; }
        //public string City { get; set; }
        //public string Township { get; set; }

    }

    public class bol_SA_FTTH_StatusModelDuration
    {
        public string TotalDuration { get; set; }
    }

        public class bol_WDM_ServicePlanPromo
    {
        public int id { get; set; }
        //FOr PROMO
        public int PROMO_ID { get; set; }
        public string PromoName_MM { get; set; }

        public string PromoName_Eng { get; set; }

       public double TotalCharges { get; set; }
        public bool IsSurchargeOn { get; set; }
        public int  SurchargePercentage { get; set; }
       public double PlanAmountwithPromo { get; set; }
        public double TaxAmount { get; set; }
        public double DepositAmount { get; set; }
    }
    public class bol_WDM_SAFormAck
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public string StatusName { get; set; }
        public bool IsSendSMS { get; set; }
        public int SMSTemplateID { get; set; }
        public string SMSTemplateName { get; set; }
        public string Message { get; set; }
        public bool IsSendEmail { get; set; }
        public int EmailTemplateID { get; set; }
        public string EmailTemplateName { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string SubType { get; set; }
        public string FromEmailAddress { get; set; }
        public string Password { get; set; }
    }
    public class bol_SPS_Reason
    {
        public int ActionParam { get; set; }
        public string Status { get; set; }
        public int ID { get; set; }
        public string Reason { get; set; }
        public int PreviousGroupID { get; set; }
        public int GroupID { get; set; }
        public int RoleID { get; set; }
        public int FinanceUser { get; set; }
    }
    public class bol_SPS_Owner
    {
        public int ActionParam { get; set; }
        public string Value { get; set; }
        public string Owner { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string GroupName { get; set; }
        public string TeamName { get; set; }
    }
    public class BSModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public string InstallationAddress { get; set; }
        public string BankForPayment { get; set; }
        public string BankPaymentName { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceSendDate { get; set; }
        public string Status { get; set; }
        public string CustomerAccountNo { get; set; }
        public bool IsAgree { get; set; }
        public string PromotionDescription { get; set; }
        public string FreeMonth { get; set; }
        public string Total { get; set; }
        public string IsSurchargeOn { get; set; }
        public string SurchargePercentage { get; set; }
        public string TaxAmount { get; set; }
        public string TotalCharges { get; set; }
        public string DOB { get; set; }
        public string NRC { get; set; }
        public string CompanyName { get; set; }
        public string CompanyRegistrationNo { get; set; }
        public string CompanySize { get; set; }
        public string TypeOfBusiness { get; set; }
        public bool IsCompany { get; set; }
        public int CityID { get; set; }
        public int TownshipID { get; set; }
        public int ServicePlanID { get; set; }
        public string ReferralCode { get; set; }
        public string CreationDate { get; set; }
        public string ContactPerson { get; set; }
        public string Designation { get; set; }
        public string CurrentInternetPlan { get; set; }
        public string Plan { get; set; }
        public bool SendReceipt { get; set; }
        public string City { get; set; }
        public string DepositAmount { get; set; }
        public string Township { get; set; }
        public string ServiceName { get; set; }
        public string ReceiptNo { get; set; }
        public string ReceiptDate { get; set; }

    }
    public class bol_SPS_PrintLog
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string SA_ID { get; set; }
        public string DownloadBy { get; set; }
        public string DownloadDate { get; set; }
    }
    public class bol_SPS_ActivityLog
    {
        public int ActionParam { get; set; }
        public int SA_ID { get; set; }
        public string Type { get; set; }
        public string? SubType { get; set; }
        public string Remark { get; set; }
        public string Datetime { get; set; }
        public string LoggedBy { get; set; }
        public string LoggedDate { get; set; }
    }
    public class bol_SPSRegionName
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string Region { get; set; }
        public string CityName { get; set; }
    }
    public class bol_SPSTownshipName
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string Township { get; set; }
    }
    public class bol_SPSGroupName
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string GroupName { get; set; }
        public string Region { get; set; }
        public string LoginUser { get; set; }
    }
    public class bol_SPSTeamName
    {
        public int ActionParam { get; set; }
        public string GroupID { get; set; }
        public int ID { get; set; }
        public string TeamName { get; set; }
        public string Region { get; set; }
        public string LoginUser { get; set; }
    }
    public class bol_SPSUserName
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Region { get; set; }
        public string LoginUser { get; set; }
    }
    public class bol_WDM_SPSStatusList
    {
        public int? New { get; set; }
        public int? FollowUp { get; set; }
        public int? Wait { get; set; }
        public int? Disqualify { get; set; }
        public int? Qualify { get; set; }
        public int? SalesLost { get; set; }
        public int? SalesWon { get; set; }
        public int? ReceivedPayment { get; set; }
        public int? SalesClosed { get; set; }

    }
    public class bol_SPS_Status
    {
        public int ActionParam { get; set; }
        public string ColorCode { get; set; }
        public string Status { get; set; }
        public int ID { get; set; }
        public int PreviousGroupID { get; set; }
        public int GroupID { get; set; }
        public int LastStatusID { get; set; }
        public int RoleID { get; set; }
        public int FinanceUser { get; set; }
        public string Name { get; set; }
        public string Plan { get; set; }
        public string CustomerAccountNo { get; set; }
        public string TotalCharges { get; set; }

    }
    public class bol_SPSCashCollector
    {
        public int ActionParam { get; set; }
        public string LoginUser { get; set; }
        public string Region { get; set; }
        public int GroupID { get; set; }
        public int TeamID { get; set; }
        public string CashCollector { get; set; }
        public string CashCollectorFullName { get; set; }
    }

}
