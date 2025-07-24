using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOL.DPSI
{
    public class bol_DPSI_SAForm
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? LeadCode { get; set; }
        public string? Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string? DOB { get; set; }
        public string? NRCPassport { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailAddress { get; set; }        
        public string? CompanyName { get; set; }
        public string? CompanyRegistrationNo { get; set; }
        public string? CompanySize { get; set; }
        public string? TypeOfBusiness { get; set; }
        public int? CityID { get; set; }
        public int? TownshipID { get; set; }
        public string? Address { get; set; }
        public string? PainPoint { get; set; }
       public string? FormattedCreatedDate { get; set; }
        public string? CreatedDate { get; set; }
        public string? City { get; set; }
        public string? Township { get; set; }
        public string? SearchText { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int PageIndex { get; set; }
        
        public string CityName { get; set; }
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
        public string Channel { get; set; }
        public string Owner { get; set; }
        public bool IsDepartmentAdmin { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string UserName { get; set; }
        public string CurrentInternetPlan { get; set; }
        public string ProductPlan { get; set; }
        public double TotalAmount { get; set; }
        public string Remark { get; set; }
        public int PreviousStatusID { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string InvoiceNo { get; set; }
        public string CustomerAccountNo { get; set; }
        public string Duration { get; set; }
        public int FinanceUser { get; set; }
        public int IsDeleteAdmin { get; set; }
        public string ProjectName { get; set; }
        public int NoOfLicense { get; set; }
        public string EdgeAppliance { get; set; }
        public int CompanyID { get; set; }
        public string ContactID { get; set; }
        public int PrimaryContact { get; set; }
        public string ProductCode { get; set; }
    }
    public class bol_DPSI_Product
    {
        public int ActionParam { get; set; }
        public string Product { get; set; }
    }
    public class bol_DPSI_Plan
    {
        public int ActionParam { get; set; }
        public string Product { get; set; }
        public int ID { get; set; }
        public string Plan { get; set; }
    }
    public class bol_DPSI_Status
    {
        public int ActionParam { get; set; }
        public string ColorCode { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
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
    public class bol_DPSI_Reason
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
    public class bol_DPSI_Owner
    {
        public int ActionParam { get; set; }
        public string Value { get; set; }
        public string Owner { get; set; }
        public string UserName { get; set; }

    }
    public class bol_DPSI_UserRolePermission
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
    public class bol_DPSI_StatusModel
    {
        public int ID { get; set; }
        public int? ActionParam { get; set; }
        public string Remark { get; set; }
        public int Status_ID { get; set; }
        public int DPSI_ID { get; set; }
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
    public class bol_DPSI_SendReceiptModel
    {
        public int ActionParam { get; set; }
        public int DPSI_ID { get; set; }
        public string CustomerAccountNo { get; set; }
        public string PaymentDocumentNo { get; set; }
        public bool SendReceipt { get; set; }
        public string OrderCode { get; set; }
    }

    public class bol_DPSI_LogActivity
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int DPSI_ID { get; set; }
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
    public class bol_DPSIProduct
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int DPSI_ID { get; set; }
        public string ServiceName { get; set; }
        public string ServicePlansID { get; set; }
        public string ServicePlanFullName { get; set; }
        public string Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsOTC { get; set; }
        public bool OTCTaxApply { get; set; }
        public string OTCTaxMode { get; set; }
        public string OTCAmount { get; set; }
        public decimal OTCTaxAmount { get; set; }
        public string OTCCurrencyConverted { get; set; }
        public string OTCTotalAmount { get; set; }
        public bool IsMRC { get; set; }
        public bool MRCTaxApply { get; set; }
        public string MRCTaxMode { get; set; }
        public string MRCAmount { get; set; }
        public decimal MRCTaxAmount { get; set; }
        public string MRCCurrencyConverted { get; set; }
        public string MRCTotalAmount { get; set; }
        public bool IsAnnualPrice { get; set; }
        public bool AnnualPriceTaxApply { get; set; }
        public string AnnualPriceTaxMode { get; set; }
        public string AnnualPriceAmount { get; set; }
        public decimal AnnualPriceTaxAmount { get; set; }
        public string AnnualPriceCurrencyConverted { get; set; }
        public string AnnualPriceTotalAmount { get; set; }
        public bool IsManagedServiceAmt { get; set; }
        public bool ManagedServiceAmtTaxApply { get; set; }
        public string ManagedServiceAmtTaxMode { get; set; }
        public string ManagedServiceAmtAmount { get; set; }
        public decimal ManagedServiceAmtTaxAmount { get; set; }
        public string ManagedServiceAmtCurrencyConverted { get; set; }
        public string ManagedServiceAmtTotalAmount { get; set; }
        public string CPU { get; set; }
        public string Memory { get; set; }
        public string HardDisk { get; set; }
        public string Bandwidth { get; set; }
        public int NoOfPublicIP { get; set; }
        public string ServiceStartDate { get; set; }
        public string ServiceEndDate { get; set; }
        public string TechnicalAssignedPerson { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public string FormattedServiceStartDate { get; set; }
        public string FormattedServiceEndDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string ProjectName { get; set; }
        public int NoOfLicense { get; set; }
        public string EdgeAppliance { get; set; }
        public string OTCTaxAmountWithMode { get; set; }
        public string MRCTaxAmountWithMode { get; set; }
        public string AnnualPriceTaxAmountWithMode { get; set; }
        public string ManagedServiceAmtTaxAmountWithMode { get; set; }

        public string OTCTotal { get; set; }
        public string MRCTotal { get; set; }
        public string AnnualPriceTotal { get; set; }
        public string ManagedServiceAmtTotal { get; set; }
    }
    public class bol_CheckDPSIContact
    {
        public int Count { get; set; }
    }
        public class bol_DPSIContact
    {
        public int ActionParam { get; set; }
        public int DPSI_ID { get; set; }
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string Title { get; set; }
        public string ContactPersonName { get; set; }
        public string DOB { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public string NRCPassport { get; set; }
        public string Note { get; set; }
        public bool IsPrimary { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string CompanyName { get; set; }
        public string RegistrationNo { get; set; }
        public string Size { get; set; }
        public string TypeOfBusiness { get; set; }
        public string CityID { get; set; }
        public string TownshipID { get; set; }
        public string Address { get; set; }

    }
    public class bol_DPSICompany
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string CompanyName { get; set; }
        public string RegistrationNo { get; set; }
        public string Size { get; set; }
        public string TypeOfBusiness { get; set; }
        public string CityID { get; set; }
        public string TownshipID { get; set; }
        public string Address { get; set; }
        public bool IsPrimary { get; set; }

    }
    public class bol_DPSIBranch
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int DPSI_ID { get; set; }
        public int CompanyID { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string ContactPersonName { get; set; }
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
    public class bol_DPSIDocument
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int DPSI_ID { get; set; }
        public string DocTypeID { get; set; }
        public string DocTypeName { get; set; }
        public string DocNo { get; set; }
        public string DocName { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string UploadedRemark { get; set; }
        public string UploadedBy { get; set; }
        public string UploadedDate { get; set; }
        public string DocDate { get; set; }
        public string ExpiredDate { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
        public string Deleted_Remark { get; set; }
        public HttpPostedFileBase DocFileUpload { get; set; }
        public string strcat { get; set; }
    }
    public class DPSIDocumentUpdate
    {
        public int ID { get; set; }
        public int DPSI_ID { get; set; }
        public string DocDate { get; set; }
        public string DocTypeID { get; set; }
        public string DocNo { get; set; }
        public string UploadedRemark { get; set; }
        public string strcat { get; set; }
     //  public HttpFileCollectionBase DocFileUpload { get; set; }
        // public HttpPostedFileBase DocFileUpload { get; set; }
    }
    public class bol_DPSI_Delete
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedRemark { get; set; }
    }
    public class bol_DPSI_DocType
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string DocName { get; set; }
        public int RoleID { get; set; }

    }
    public class bol_DPSI_ResponseModel
    {
        public string RespCode { get; set; }
        public string RespDescription { get; set; }
        public int DPSI_ID { get; set; }
    }
    public class bol_DPSI_TechnicialAssignedPerson
    {
        public int ActionParam { get; set; }
        public string Value { get; set; }
        public string Owner { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }

    }
    public class bol_DPSI_Product_Setup
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int DPSI_ID { get; set; }
        public string ServiceName { get; set; }
        public string ServicePlansID { get; set; }
        public string Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsOTC { get; set; }
        public bool OTCTaxApply { get; set; }
        public string OTCTaxMode { get; set; }
        public string OTCAmount { get; set; }
        public decimal OTCTaxAmount { get; set; }
        public string OTCCurrencyConverted { get; set; }
        public string OTCTotalAmount { get; set; }
        public bool IsMRC { get; set; }
        public bool MRCTaxApply { get; set; }
        public string MRCTaxMode { get; set; }
        public string MRCAmount { get; set; }
        public decimal MRCTaxAmount { get; set; }
        public string MRCCurrencyConverted { get; set; }
        public string MRCTotalAmount { get; set; }
        public bool IsAnnualPrice { get; set; }
        public bool AnnualPriceTaxApply { get; set; }
        public string AnnualPriceTaxMode { get; set; }
        public string AnnualPriceAmount { get; set; }
        public decimal AnnualPriceTaxAmount { get; set; }
        public string AnnualPriceCurrencyConverted { get; set; }
        public string AnnualPriceTotalAmount { get; set; }
        public bool IsManagedServiceAmt { get; set; }
        public bool ManagedServiceAmtTaxApply { get; set; }
        public string ManagedServiceAmtTaxMode { get; set; }
        public string ManagedServiceAmtAmount { get; set; }
        public decimal ManagedServiceAmtTaxAmount { get; set; }
        public string ManagedServiceAmtCurrencyConverted { get; set; }
        public string ManagedServiceAmtTotalAmount { get; set; }
        public string CPU { get; set; }
        public string Memory { get; set; }
        public string HardDisk { get; set; }
        public string Bandwidth { get; set; }
        public int NoOfPublicIP { get; set; }
        public string ServiceStartDate { get; set; }
        public string ServiceEndDate { get; set; }
        public string TechnicalAssignedPerson { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string ProjectName { get; set; }
        public int NoOfLicense { get; set; }
        public string EdgeAppliance { get; set; }
    }
    public class bol_IsHaveDPSIDocument
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string DocType { get; set; }
        public int Count { get; set; }

    }
    public class bol_IsHaveDPSIProduct
    {
        public int ActionParam { get; set; }
        public int DPSI_ID { get; set; }

    }
    public class bol_DPSI_CheckSODate
    {
        public int ActionParam { get; set; }
        public int DPSI_ID { get; set; }
        public string Result { get; set; }
    }
    public class bol_DPSI_CheckProductAmount
    {
        public int ActionParam { get; set; }
        public int DPSI_ID { get; set; }
        public string Result { get; set; }
    }
    public class bol_DPSIChannel
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string Channel { get; set; }
        public int RowNumber { get; set; }
    }
}
