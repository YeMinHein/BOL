using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_BSS
    {
    }

    public class bol_API_BSS_GetCustomerCodes
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public string billingAccountNo { get; set; }
        public string serviceInstanceNo { get; set; }
        public string serviceAccountNo { get; set; }

        public string PlanName { get; set; }
        public string Status { get; set; }
    }

    public class bol_API_BSS_GetServiceBalance
    {
        public int ActionParam { get; set; }
        public string FullName { get; set; }
        public string Category { get; set; }

    }

    public class bol_API_BSS_SyncAccountHistory
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public string serviceInstanceNumber { get; set; }
        public string planName { get; set; }
        public string planStatus { get; set; }
        public DateTime dateTime { get; set; }
        public string staffId { get; set; }
        public string staffName { get; set; }
        public string functionality { get; set; }
        public string remark { get; set; }
        public string valueBefore { get; set; }
        public string valueAfter { get; set; }
    }

    public class bol_API_BSS_GetCreationDateByCustAccNo
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public DateTime creationDate { get; set; }
    }

    public class bol_API_BSS_GetOpeningBalanceByCustAccNo
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public int RowCounts { get; set; }
    }

    public class bol_API_BSS_SyncBillList
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public string billingAccountNumbrer { get; set; }
        public string AccountStatus { get; set; }
        public string CurrentPlan { get; set; }
        public string Name { get; set; }
        public string billNumber { get; set; }
        public string documentType { get; set; }
        public decimal amount { get; set; }
        public decimal unpaidAmount { get; set; }
        public DateTime billDate { get; set; }
        public DateTime dueDate { get; set; }
        public string billStatus { get; set; }
        public string disputedStatus { get; set; }
        public string billMonth { get; set; }
        public string billId { get; set; }
        public string currencyName { get; set; }
    }

    public class bol_API_BSS_SyncBillListV2
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public string billingAccountNumbrer { get; set; }
        public string AccountStatus { get; set; }
        public string CurrentPlan { get; set; }
        public string Name { get; set; }
        public string billNumber { get; set; }
        public string documentType { get; set; }
        public decimal amount { get; set; }
        public decimal unpaidAmount { get; set; }
        public DateTime billDate { get; set; }
        public DateTime dueDate { get; set; }
        public string billStatus { get; set; }
        public string disputedStatus { get; set; }
        public string billMonth { get; set; }
        public string billId { get; set; }
        public string currencyName { get; set; }

        public DataTable udt_BillList { get; set; }
    }

    public class bol_API_BSS_SyncBillList_CustomerList
    {
        public DataTable test { get; set; }
    }

    public class bol_API_BSS_SyncStaff
    {
        public int ActionParam { get; set; }
        public int staffId { get; set; }
        public string staffName { get; set; }
        public string username { get; set; }
        public string accountStatus { get; set; }
        public string address { get; set; }
        public string cityName { get; set; }
        public string stateName { get; set; }
        public string countryName { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string businessGrpName { get; set; }
        public string businessGrpHieName { get; set; }
        public string organizationName { get; set; }
        public string loggedInStaffId { get; set; }
        public string birthDate { get; set; }
        public int organizationId { get; set; }
        public string externalId { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public int sId { get; set; }
        public string acluserDetails { get; set; }
        public bool allowLogin { get; set; }
        public string visibilityFlag { get; set; }
        public string lowerUserName { get; set; }
    }
    public class bol_API_BSS_SyncStaff_BillingAreaName
    {
        public int ActionParam { get; set; }
        public int staffId { get; set; }
        public string billingAreaNameId { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string visibilityFlag { get; set; }
    }

    public class bol_API_BSS_AccountStatement
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public decimal totalClosingBalance { get; set; }
        public decimal depositPaid { get; set; }
        public string currencyName { get; set; }
    }

    public class bol_API_BSS_AccountStatementDetail
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public string documentnumber { get; set; }
        public DateTime postDate { get; set; }
        public string documentType { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public string currencyName { get; set; }
        public decimal balance { get; set; }
    }

    public class bol_API_BSS_InstallationOrder
    {
        public int ActionParam { get; set; }
        public DataTable IntallationOrders { get; set; }
    }

    public class bol_API_BSS_GetAccountHistoryDatetime      //BSS (Order By dateTime DESC)
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public DateTime? dateTime { get; set; }
    }


    public class bol_API_BSS_GetServiceInstanceSummaryDetail
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public string serviceInstanceNumber { get; set; }
        public string planName { get; set; }
        public string planId { get; set; }
        public string planStatus { get; set; }
        public string planType { get; set; }
        public DateTime expiryDate { get; set; }
        public string userName { get; set; }
        public string currencyId { get; set; }
        public string basicPackageHistoryId { get; set; }
        public string basicPackageServiceAlias { get; set; }
        public DateTime activationDate { get; set; }
        public DateTime contractstartdate { get; set; }
        public DateTime contractenddate { get; set; }
        public int noofyears { get; set; }
        public string billingStatus { get; set; }
        public string promoName { get; set; }
        public DateTime promoStartDate { get; set; }
        public DateTime promoEndDate { get; set; }
        public string billiareaalias { get; set; }
        public string starterPackValidityActive { get; set; }
        public string currencyAlias { get; set; }
    }

    public class bol_API_BSS_UpdatePersonalData
    {
        public int ActionParam { get; set; }
        public string customerAccountNo { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
    }

    public class bol_API_BSS_SyncIO
    {
        public int ActionParam { get; set; }
        public int orderId { get; set; }
        public string promotionname { get; set; }
        public string? condosalesmasterName { get; set; }
        public string orderStatus { get; set; }
        public int ownedByGroup { get; set; }
        public string password { get; set; }
        public string? condosalesmasterId { get; set; }
        public string planname { get; set; }
        public string? customerLastName { get; set; }
        public string? appointmentDateTime { get; set; }
        public string installationEndDate { get; set; }
        public string installationAssignDate { get; set; }
        public string? customerAddress { get; set; }
        public string address { get; set; }
        public string customerAccNo { get; set; }
        public string PhoneNo { get; set; }
        public string custName { get; set; }
        public string customerRMN { get; set; }
        public string customerFirstName { get; set; }
        public int installationId { get; set; }
        public int RN { get; set; }
        public string? ownedBy { get; set; }
        public string assignToGroup { get; set; }
        public string? assignTo { get; set; }
        public int isUpdate { get; set; }
        public string township { get; set; }
        public string username { get; set; }

        public DateTime formattedInstallationEndDate { get; set; }
        public DateTime formattedInstallationAssignDate { get; set; }
        public DateTime formattedAppointmentDateTime { get; set; }

    }

    public class bol_API_BSS_SyncIOV2
    {
        public int ActionParam { get; set; }
        public int orderId { get; set; }
        public string promotionname { get; set; }
        public string? condosalesmasterName { get; set; }
        public string orderStatus { get; set; }
        public int ownedByGroup { get; set; }
        public string password { get; set; }
        public string? condosalesmasterId { get; set; }
        public string planname { get; set; }
        public string? customerLastName { get; set; }
        public string? appointmentDateTime { get; set; }
        public string installationEndDate { get; set; }
        public string installationAssignDate { get; set; }
        public string? customerAddress { get; set; }
        public string address { get; set; }
        public string customerAccNo { get; set; }
        public string PhoneNo { get; set; }
        public string custName { get; set; }
        public string customerRMN { get; set; }
        public string customerFirstName { get; set; }
        public int installationId { get; set; }
        public int RN { get; set; }
        public string? ownedBy { get; set; }
        public string assignToGroup { get; set; }
        public string? assignTo { get; set; }
        public int isUpdate { get; set; }
        public string township { get; set; }
        public string username { get; set; }

        public DateTime formattedInstallationEndDate { get; set; }
        public DateTime formattedInstallationAssignDate { get; set; }
        public DateTime formattedAppointmentDateTime { get; set; }

        public string cafId { get; set; }
        public string cafRefOrderId { get; set; }
        public DateTime? orderEndDate { get; set; }
        public string multipleCustomerContactNo { get; set; }
        public string planId { get; set; }
    }
    public class bol_API_SyncPXChangeServicePlanModel
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public string serviceInstanceNumber { get; set; }
        public DateTime effectiveDate { get; set; }
        public string currencyAlias { get; set; }
        public string packageName { get; set; }
        public string remarks { get; set; }
        public string PMRVO_paymentMode { get; set; }
        public string PMRVO_CMR_paymentMode { get; set; }
        public string PMRVO_manualReceiptNumber { get; set; }
        public string PMRVO_description { get; set; }
        //public DateTime PMRVO_paymentDate { get; set; }         //NSL Edit
        public string PMRVO_paymentDate { get; set; }
        public int PMRVO_totalTransactionAmount { get; set; }
        public string PMRVO_otherBankName { get; set; }
        public string PMRVO_otherBranchName { get; set; }
        public string partnerAccountNumber { get; set; }
        public string organizationId { get; set; }
        public string packageId { get; set; }
        public string modulename { get; set; }
        public string CRDRNRVO_billingAccountNumber { get; set; }
        public int CRDRNRVO_subtotal { get; set; }
        public string noofyears { get; set; }
        public string eventType { get; set; }
        public string CDRVO_chargeId { get; set; }
        public string CDRVO_chargeName { get; set; }
        public bool CDRVO_canOverride { get; set; }
        public int CDRVO_actualAmount { get; set; }
        public string? CDRVO_overriddenBy { get; set; }
        public int? CDRVO_overriddenAmount { get; set; }
        public bool? CDRVO_isOverridden { get; set; }
        //public int? CDRVO_overrideLimitMin { get; set; }
        //public int? CDRVO_overrideLimitMax { get; set; }
        public decimal? CDRVO_overrideLimitMin { get; set; }
        public decimal? CDRVO_overrideLimitMax { get; set; }
        public string CreatedDate { get; set; }
        public string Type { get; set; }


        public string DocumentAlias { get; set; }
        public string ReceivableChannelAlias { get; set; }
        public string PaymentSource { get; set; }
        public string PaymentOperator { get; set; }
        public string InternetRefNo { get; set; }
        public string CRNo { get; set; }
        public string BillInvoiceNo { get; set; }
        public string merch_order_id { get; set; }

        public string CreatedBy { get; set; }
        public int AmendLogID { get; set; }

        public string RespCode { get; set; }

        public string OldPlanName { get; set; }
    }

    public class bol_API_BSS_CAF_PackageChargesModel
    {
        public int ActionParam { get; set; }
        public string packageId { get; set; }
        public string chargeId { get; set; }
        public string chargeName{ get; set; }
        public bool canOverride { get; set; }
        public int actualAmount { get; set; }
        public string? overriddenBy { get; set; }
        public int? overriddenAmount { get; set; }
        public bool? isOverridden { get; set; }
        //public int? overrideLimitMin { get; set; }
        //public int? overrideLimitMax { get; set; }
        public decimal? overrideLimitMin { get; set; }
        public decimal? overrideLimitMax { get; set; }
    }

    public class bol_API_BSS_SyncCondoSales
    {
        public int ActionParam { get; set; }
        public string VISIBILITYFLAG { get; set; }
        public string CITY { get; set; }
        public string COUNTRY { get; set; }
        public int CONDOMASTERID { get; set; }
        public string STATE { get; set; }
        public int RN { get; set; }
        public string NAME { get; set; }

        public int detail_condoMasterId { get; set; }
        public string detail_name { get; set; }
        public string flatHouseNum { get; set; }
        public string buildingName { get; set; }
        public string streetRoad { get; set; }
        public string detail_visibilityflag { get; set; }
        public string pinCode { get; set; }
        public string city_id { get; set; }
        public string city_name { get; set; }
        public string city_alias { get; set; }
        public string city_visibilityFlag { get; set; }
        public string state_id { get; set; }
        public string state_name { get; set; }
        public string state_alias { get; set; }
        public string state_visibilityFlag { get; set; }
        public string country_id { get; set; }
        public string country_name   { get; set; }
        public string country_alias { get; set; }
        public string country_visibilityFlag { get; set; }
    }

    #region Evo
    public class bol_API_SyncChangeServicePlanModel
    {
        public int ActionParam { get; set; }
        public string customerAccountNumber { get; set; }
        public string custCode { get; set; }
        public string accountCode { get; set; }
        public string offerCode { get; set; }

        public DateTime? effectiveDate { get; set; }
        public string currencyAlias { get; set; }
        public string packageName { get; set; }
        public string remarks { get; set; }
        public string PMRVO_paymentMode { get; set; }
        public string PMRVO_CMR_paymentMode { get; set; }
        public string PMRVO_manualReceiptNumber { get; set; }
        public string PMRVO_description { get; set; }
        //public DateTime PMRVO_paymentDate { get; set; }         //NSL Edit
        public string PMRVO_paymentDate { get; set; }
        public int PMRVO_totalTransactionAmount { get; set; }
        public string PMRVO_otherBankName { get; set; }
        public string PMRVO_otherBranchName { get; set; }
        public string partnerAccountNumber { get; set; }
        public string organizationId { get; set; }
        public string packageId { get; set; }
        public string modulename { get; set; }
        public string CRDRNRVO_billingAccountNumber { get; set; }
        public int CRDRNRVO_subtotal { get; set; }
        public string noofyears { get; set; }
        public string eventType { get; set; }
        public string CDRVO_chargeId { get; set; }
        public string CDRVO_chargeName { get; set; }
        public bool CDRVO_canOverride { get; set; }
        public int CDRVO_actualAmount { get; set; }
        public string? CDRVO_overriddenBy { get; set; }
        public int? CDRVO_overriddenAmount { get; set; }
        public bool? CDRVO_isOverridden { get; set; }
        //public int? CDRVO_overrideLimitMin { get; set; }
        //public int? CDRVO_overrideLimitMax { get; set; }
        public decimal? CDRVO_overrideLimitMin { get; set; }
        public decimal? CDRVO_overrideLimitMax { get; set; }
        public string CreatedDate { get; set; }
        public string Type { get; set; }


        public string DocumentAlias { get; set; }
        public string ReceivableChannelAlias { get; set; }
        public string PaymentSource { get; set; }
        public string PaymentOperator { get; set; }
        public string InternetRefNo { get; set; }
        public string CRNo { get; set; }
        public string BillInvoiceNo { get; set; }
        public string merch_order_id { get; set; }

        public string CreatedBy { get; set; }
        public int AmendLogID { get; set; }

        public string RespCode { get; set; }

        public string OldPlanName { get; set; }
    }

    #endregion
}
