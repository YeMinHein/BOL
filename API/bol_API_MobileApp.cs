using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_MobileApp
    {
    }

    public class bol_API_GetReferral
    {
        public int ActionParam { get; set; }
        public string ActionField { get; set; }
        public string CustAccNo { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }
        public string ReferralCode { get; set; }

    }

    public class bol_API_GetReferralResModel
    {
        public string CustAccNo { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }
        public string ReferralCode { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }

    public class bol_API_CheckVerification
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string MobileNo { get; set; }
        public string UpdateMobileNo { get; set; }
        public string UpdateNRC { get; set; }
        public int Step { get; set; }
        public string VerifiedDate { get; set; }

        public string UpdateNRCCode { get; set; }
        public string UpdateNRCTownship { get; set; }
        public string UpdateNRCA { get; set; }
        public string UpdateNRCNo { get; set; }

        public int SendVCodeStep1Count { get; set; }
        public int SendVCodeStep3Count { get; set; }

        public string Nationality { get; set; }
        public string PassportNo { get; set; }
        public string VerifyBy { get; set; }

        public int SMSStep { get; set; }
        public string Step1SMSStatus { get; set; }
        public string Step3SMSStatus { get; set; }
    }


    public class bol_API_GetPlanByCustAccNo
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string PlanName { get; set; }
        public double Price { get; set; }

    }

    public class bol_API_PlanPriceListByCustAccNo
    {
        public int ActionParam { get; set; }
        public string CustomerAccountNo { get; set; }
        //public List<bol_API_PlanPriceList> bol_API_PlanPriceList { get; set; }
        public bol_API_PlanPriceList data { get; set; }

    }


    public class bol_API_PlanPriceList
    {
        public int ID { get; set; }
        public string PromoName_Eng { get; set; }
        public string PromoName_MM { get; set; }
        public string PlanName { get; set; }
        public int Price { get; set; }
        public string Amount { get; set; }
        public int CalculateAmount { get; set; }
        public string Note { get; set; }


        public int TaxPercentage { get; set; }
        public string TaxAmount { get; set; }
        public int CalculateTaxAmount { get; set; }
        public string TotalAmount { get; set; }
        public int CalculateTotalAmount { get; set; }
    }

    public class bol_API_CurrentPXPlanPriceList
    {
        public string PackageID { get; set; }
        //public string PromoName_Eng { get; set; }
        //public string PromoName_MM { get; set; }
        public string PlanName { get; set; }
        public string FullName { get; set; }
        public string PkgDisplayName { get; set; }
        public int Price { get; set; }
        public string Amount { get; set; }
        public int CalculateAmount { get; set; }
        //public string Note { get; set; }

        public int TaxPercentage { get; set; }
        public string TaxAmount { get; set; }
        public int CalculateTaxAmount { get; set; }
        public string TotalAmount { get; set; }
        public int CalculateTotalAmount { get; set; }

        public string DownloadSpeed { get; set; }
        public string UploadSpeed { get; set; }
        public int Validity { get; set; }
        //public string Validity { get; set; }
        public int PromoDay { get; set; }
        //public string PromoDay { get; set; }
        public string ValidityLabel { get; set; }
        public int SortOrder { get; set; }

        public string ExpiryDate { get; set; }
        public string NextPlanStartDate { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public string ExpireIn { get; set; }
        public string Note { get; set; }

    }
    public class bol_API_NextPXPlanPriceList
    {
        //public int ID { get; set; }
        public string PackageID { get; set; }
        public string PlanName { get; set; }
        public string FullName { get; set; }
        public string PkgDisplayName { get; set; }
        public int Price { get; set; }
        public string Amount { get; set; }
        public int CalculateAmount { get; set; }

        public int TaxPercentage { get; set; }
        public string TaxAmount { get; set; }
        public int CalculateTaxAmount { get; set; }
        public string TotalAmount { get; set; }
        public int CalculateTotalAmount { get; set; }

        public string DownloadSpeed { get; set; }
        public string UploadSpeed { get; set; }
        public int Validity { get; set; }
        //public string Validity { get; set; }
        public int PromoDay { get; set; }
        //public string PromoDay { get; set; }
        public string ValidityLabel { get; set; }
        public int SortOrder { get; set; }

        //public string ExpiryDate { get; set; }
        //public string NextPlanStartDate { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
    public class bol_API_PXPlanPriceList
    {
        //public int ID { get; set; }
        public string PackageID { get; set; }
        //public string PromoName_Eng { get; set; }
        //public string PromoName_MM { get; set; }
        public string PlanName { get; set; }
        public string FullName { get; set; }
        public string PkgDisplayName { get; set; }
        public int Price { get; set; }
        public string Amount { get; set; }
        public int CalculateAmount { get; set; }
        //public string Note { get; set; }

        public int TaxPercentage { get; set; }
        public string TaxAmount { get; set; }
        public int CalculateTaxAmount { get; set; }
        public string TotalAmount { get; set; }
        public int CalculateTotalAmount { get; set; }

        public string DownloadSpeed { get; set; }
        public string UploadSpeed { get; set; }
        public int Validity { get; set; }
        //public string Validity { get; set; }
        public int PromoDay { get; set; }
        //public string PromoDay { get; set; }
        public string ValidityLabel { get; set; }
        public int SortOrder { get; set; }
    }

    public class bol_API_CurrentPlan
    {
        public int AdvancePaymentFormID { get; set; }
        public int ID { get; set; }
        public string PromoName_Eng { get; set; }
        public string PromoName_MM { get; set; }
        public string PlanName { get; set; }
        public int Price { get; set; }
        public string Amount { get; set; }
        public string BankForPayment { get; set; }


        public int TaxPercentage { get; set; }
        public string TaxAmount { get; set; }
        public string TotalAmount { get; set; }
    }

    public class bol_API_InsertPlanAdvance
    {
        public int ActionParam { get; set; }
        public string CustomerAccountNo { get; set; }
        public int PlanID { get; set; }
    }

    public class bol_API_AccountVerification
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string VerifyType { get; set; }
        public string VerifyAccount { get; set; }
        //public string VerifySecondaryAccount { get; set; }
        public string Remark { get; set; }
        public string VerificationCode { get; set; }
        public int ExpireMinutes { get; set; }
    }

    public class bol_API_EmailList
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string VerifyType { get; set; }
        public string Email { get; set; }
        public bool IsPrimary { get; set; }
        public string VerifiedDate { get; set; }
    }
    public class bol_API_EmailList_Result
    {
        public string Email { get; set; }
        public bool IsPrimary { get; set; }
        public string VerifiedDate { get; set; }
        public bool IsBSSPrimary { get; set; }
    }


    public class bol_API_AppExceptionLog
    {
        public int ActionParam { get; set; }
        public string OS { get; set; }
        public string VersionNo { get; set; }
        public string AppVersion { get; set; }
        public string Source { get; set; }
        public string URL { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public string RequestData { get; set; }
    }

    public class bol_API_Login_History_Log
    {
        public int ActionParam { get; set; }
        public string ProjectCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DeviceID { get; set; }
    }

    public class bol_API_City
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string CityName { get; set; }
        public string CityName_MM { get; set; }
        public int OrderNo { get; set; }
    }
    public class bol_API_City_Req
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }
    }
    public class bol_API_City_Response
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public string CityName_MM { get; set; }
        public int OrderNo { get; set; }
    }
    public class bol_API_Township
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int? City_ID { get; set; }
        public string Township { get; set; }
    }
    public class bol_API_Township_Response
    {
        public int ID { get; set; }
        public int City_ID { get; set; }
        public string Township { get; set; }
    }

    public class bol_API_ServiceBasePlan
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string ServiceType { get; set; }
        public string PlanName { get; set; }
        public string Description { get; set; }
        public int DownloadSpeed { get; set; }
        public int UploadSpeed { get; set; }
        public string DownloadUnit { get; set; }
        public string UploadUnit { get; set; }
        public string Features { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string planId { get; set; }
        public string PlanType { get; set; }
        public int Quota { get; set; }
        public int Validity { get; set; }
    }
    public class bol_API_ServiceBasePlan_Response
    {
        public int ID { get; set; }
        public string ServiceType { get; set; }
        public string PlanName { get; set; }
        public string Description { get; set; }
        public int DownloadSpeed { get; set; }
        public int UploadSpeed { get; set; }
        public string DownloadUnit { get; set; }
        public string UploadUnit { get; set; }
        public string Features { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string planId { get; set; }
        public string PlanType { get; set; }
        public int Quota { get; set; }
        public int Validity { get; set; }
    }

    public class bol_API_LoginLogResult
    {
        public int ActionID { get; set; }
    }
    public class bol_API_LoginUser
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
    }
    public class bol_API_DataVersion
    {
        public string ProjectCode { get; set; }
        public string Item { get; set; }
        public string Version { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class bol_API_Login
    {
        public ResultMsg result { get; set; }
        public bol_API_LoginUser user { get; set; }
        public List<bol_API_DataVersion> dataVersion { get; set; }
    }

    public class bol_API_PAY_PaymentMethod
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string BankName { get; set; }
        public string Value { get; set; }
        public string Status { get; set; }
        public int SortOrder { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMobileActive { get; set; }
    }

    public class bol_API_PAY_PaymentMethod_Response
    {
        public int ID { get; set; }
        public string BankName { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public int SortOrder { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMobileActive { get; set; }
    }


    public class bol_API_OnOff
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string userName { get; set; }
        public string Status { get; set; }      //active/inactive
        //CreatedDate
    }

    public class bol_API_GPS
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string userName { get; set; }
        public string Type { get; set; }        //login/logout/onoff/regular

        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? BatteryPercentage { get; set; }
        public int? ActionID { get; set; }
        //CreatedDate
    }

    public class bol_API_LeadForm
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string userName { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Plan { get; set; }
        public string City { get; set; }
        public string Township { get; set; }
        public string Address { get; set; }
    }

    public class bol_API_LeadEntryForm
    {
        public int ActionParam { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public int? CityID { get; set; }
        public int? TownshipID { get; set; }
        public int? ServicePlanID { get; set; }
        public int LeadSourceID { get; set; }
        public int? ChannelID { get; set; }
        public string Remark { get; set; }
        public string LoggedBy { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int BatteryPercentage { get; set; }
    }
    public class bol_API_Res_LeadEntryForm
    {
        public string RespCode { get; set; }
        public int SAID { get; set; }
    }
    public class bol_API_SPSLeadsCount
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }
    }
    public class bol_API_SPSLeadsCount_Response
    {
        public int Leads { get; set; }
        public int SalesWon { get; set; }
        public int TodayLeads { get; set; }
        public int TodaySalesWon { get; set; }
    }

    public class bol_API_ChangePassword
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
    public class bol_API_Res_ChangePassword
    {
        public string RespCode { get; set; }
        public string Message { get; set; }
    }
    public class bol_API_SPSCashCollectorDashboard_Response
    {
        public int OneMonthCustomerCount { get; set; }
        public decimal OneMonthCollectedCashAmount { get; set; }
        public int TodayCustomerCount { get; set; }
        public decimal TodayCollectedCashAmount { get; set; }
        public decimal MinimumAmount { get; set; }
    }

}
