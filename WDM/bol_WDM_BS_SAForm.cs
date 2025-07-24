using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_BS_SAForm
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? DOB { get; set; }
        public string? NRCPassport { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyRegistrationNo { get; set; }
        public string? CompanySize { get; set; }
        public string? TypeOfBusiness { get; set; }
        public string? InstallationAddress { get; set; }
        public int? CityID { get; set; }
        public int? TownshipID { get; set; }
        public string? EmailAddress { get; set; }
        public string? MobileNo { get; set; }
        public string VerifyMobileNo { get; set; }
        public int? ServicePlanID { get; set; }
        public string? BankForPayment { get; set; }
        public string? CreationDate { get; set; }
        public bool? SendReceipt { get; set; }
        public string? FormattedCreatedDate { get; set; }
        public string? City { get; set; }
        public string? Township { get; set; }
        public string? ServicePlan { get; set; }
        public string PlanName { get; set; }
        public string? SearchText { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int PageIndex { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int PromoPlanID { get; set; }
        public string PromoName { get; set; }
        public string OrderCode { get; set; }
        public string CityName { get; set; }
        public string? BuildingName { get; set; }
        public int? BuildingTypeID { get; set; }
        public string LastStatus { get; set; }
        public string LastLoggedBy { get; set; }
        public string LastLoggedDate { get; set; }
        public bool? IsOnlyMe { get; set; }
        public int? LastStatusID { get; set; }
        public string LastStatusParentName { get; set; }
        public string LastStatusName { get; set; }
        public string[] StatusArray { get; set; }
        public string Status { get; set; }
        public string ColorCode { get; set; }
        public int LastGroupID { get; set; }
        public string? Reason { get; set; }
        public string Product { get; set; }
        public string Source { get; set; }
        public string Owner { get; set; }
        public bool IsDepartmentAdmin { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string UserName { get; set; }
        public int NoofBranch { get; set; }
        public string CurrentInternetPlan { get; set; }
        public string ProductPlan { get; set; }
        public double TotalAmount { get; set; }
        public string Remark { get; set; }
        public int PreviousStatusID { get; set; }
        public string Title { get; set; }
        public string Designation { get; set; }
        public string CreatedBy { get; set; }
        public string InvoiceNo { get; set; }
        public string CustomerAccountNo { get; set; }
        public bool IsAgree { get; set; }
        public string FormattedAgreementDate { get; set; }
        public bool SendTermsAndConditions { get; set; }
        public string PaymentDocNo { get; set; }
        public string Duration { get; set; }
        public string IncludeCustAccNo { get; set; }
        public int FinanceUser { get; set; }
        public int IsDeleteAdmin { get; set; }
        public string FormattedSendReceiptDate { get; set; }
        public bool IsSurchargeOn { get; set; }
        public decimal SurchargePercentage { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal PlanAmountwithPromo { get; set; }
    }
    public class bol_BS_Product
    {
        public int ActionParam { get; set; }
        public string Product { get; set; }
    }
    public class bol_BS_Plan
    {
        public int ActionParam { get; set; }
        public string Product { get; set; }
        public int ID { get; set; }
        public string Plan { get; set; }
    }
    public class bol_BS_Status
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
        public string MobileNo { get; set; }
        public string LastLoggedDate { get; set; }

    }
    public class bol_BS_Reason
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
    public class bol_BS_Owner
    {
        public int ActionParam { get; set; }
        public string Value { get; set; }
        public string Owner { get; set; }
        public string UserName { get; set; }

    }
    public class bol_BS_UserRolePermission
    {
        public int ActionParam { get; set; }
        public string userName { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsDepartmentAdmin { get; set; }
        public bool IsSuperAdmin { get; set; }
    }
    //public class bol_FTTH_StatusModel
    //{
    //    public int ID { get; set; }
    //    public int GroupID { get; set; }
    //    public string Status { get; set; }
    //    public string StatusName { get; set; }
    //    public int ParentGroupID { get; set; }
    //    public bool IsActive { get; set; }
    //    public int SortOrder { get; set; }
    //    public bool IsSentEmail { get; set; }


    //}
    public class bol_BS_StatusModel
    {
        public int ID { get; set; }
        public int? ActionParam { get; set; }
        public string Remark { get; set; }
        public int Status_ID { get; set; }
        public int BS_ID { get; set; }
        public string LoggedBy { get; set; }
        public DateTime LoggedDate { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string StatusColorCode { get; set; }
        public string Owner { get; set; }
        //public string LoggedDateStr { get; set; }
        //public int ParentGroupID { get; set; }
        //public string Step { get; set; }
        //public string StepStatus { get; set; }

        public bool SendReceipt { get; set; }
    }
    public class bol_BS_SendReceiptModel
    {
        public int ActionParam { get; set; }
        public int BS_ID { get; set; }
        public string CustomerAccountNo { get; set; }
        public string PaymentDocumentNo { get; set; }
        public bool SendReceipt { get; set; }
        public string OrderCode { get; set; }
    }

    public class bol_WDM_BusinessLogActivity
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int BS_ID { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Remark { get; set; }
        public string Datetime { get; set; }
        public string LoggedBy { get; set; }
        public string LoggedDate { get; set; }
        public string FormattedDatetime { get; set; }
        public string FormattedLoggedDate { get; set; }
        public string Icon { get; set; }
        public string FullName { get; set; }
        public string header { get; set; }
        public string LastStatus { get; set; }
        public string ColorCode { get; set; }
        public string datedifference { get; set; }
    }
    public class bol_WDM_BSContact
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int BS_ID { get; set; }
        public string Title { get; set; }
        public string ContactPerson { get; set; }
        public string Designation { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public bool IsPrimary { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
    }
    public class bol_WDM_BSBranch
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int BS_ID { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string ContactPerson { get; set; }
        public int ServicePlanID { get; set; }
        public string PlanName { get; set; }
        public string CustomerAccountNo { get; set; }
        public bool IsMain { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
    }
    public class bol_BS_Delete
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedRemark { get; set; }
    }
    public class bol_SPS_LeadCode
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string LeadCode { get; set; }
    }
    public class bol_SPS_CreatedDate
    {
        public int ActionParam { get; set; }
        public string LeadCode { get; set; }
        public string FormattedCreatedDate { get; set; }
    }
    public class bol_SPS_CollectedCashBaseAmount
    {
        public int ActionParam { get; set; }
        public int CollectedCashBaseAmount { get; set; }
    }

}
