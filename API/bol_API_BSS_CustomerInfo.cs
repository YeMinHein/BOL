using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_BSS_CustomerInfo
    {
    }

    #region CustomerInfoRequestModel
    public class bol_CustomerInfo
    {
        public int ActionParam { get; set; }
        public string CustomerAccNo { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string EmailAddress { get; set; }
        public string RegisteredMobileNumber { get; set; }
        public string BillingArea { get; set; }
        public string CustomerCategory { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string BillCycle { get; set; }
        public string NRC { get; set; }
        public string MobileNo { get; set; }
    }
    #endregion

    #region CustomerInfoRequestModel
    public class bol_CustomerAccDetail
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

        public string flatHouseNum { get; set; }
        public string buildingSocietyName { get; set; }
        public string landmark { get; set; }
    }
    #endregion

    #region BillingAccountDetailsRequestModel
    public class bol_BillingAccountDetails
    {
        public int ActionParam { get; set; }
        public string BillingAccountNo { get; set; }
        public string CustomerAccountNo { get; set; }
        public string Name { get; set; }
        public string CreationDate { get; set; }
        public string Status { get; set; }
        public string BillingCycle { get; set; }
        public string Currency { get; set; }
        public string BillingOnHold { get; set; }
        public string CreditClass { get; set; }
        public string BillDeliveryMode { get; set; }
        public string DunningStatus { get; set; }
        public string GEOID { get; set; }
        public string TaxType { get; set; }
        public string BillingAreaID { get; set; }
    }
    #endregion

    #region ServiceAccountDetailsRequestModel
    public class bol_ServiceAccountDetails
    {
        public int ActionParam { get; set; }
        public string ServiceAccountNo { get; set; }
        public string CustomerAccNo { get; set; }
        public string Name { get; set; }
        public string CreationDate { get; set; }
        public string GEOID { get; set; }
        public string ServiceType { get; set; }
    }
    #endregion

    #region ServiceInstanceDetailsRequestModel
    public class bol_ServiceInstanceDetails
    {
        public int ActionParam { get; set; }
        public string ServiceInstanceNo { get; set; }
        public string ServiceAccountNo { get; set; }
        public string CustomerAccountNo { get; set; }
        public string Name { get; set; }
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
        public string ExpiryDate { get; set; }
    }
    #endregion

    #region PromotionDetailsRequestModel
    public class bol_PromotionDetails
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int PromoID { get; set; }
        public string CustomerAccountNo { get; set; }
        public string Name { get; set; }
        public string PeriodInMonth { get; set; }
        public string PromoProductType { get; set; }
        public string UnitType { get; set; }
        public string PriceUnitType { get; set; }
        public Decimal Price { get; set; }
        public string CurrencyType { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
    }
    #endregion

    #region DepositDetailsRequestModel
    public class bol_DepositDetails
    {
        public string accountNumber { get; set; }
        public decimal amountDue { get; set; }
        public decimal depositAmount { get; set; }
        public string depositName { get; set; }
        public string depositType { get; set; }
        public string status { get; set; }
        public decimal amtTransferredRefund { get; set; }
        public int maturityDays { get; set; }
        public int maturityMonths { get; set; }
        public string depositDetailId { get; set; }
    }
    #endregion

    #region Get Service Instance Info
    public class bol_GetServiceInstanceInfo
    {
        public int ActionParam { get; set; }
        public string CustAccNos { get; set; }
        public string CustAccNo { get; set; }
        public string PlanName { get; set; }
        public string Status { get; set; }
    }
    public class bol_GetServiceInstanceInfoResModel
    {
        public string CustAccNo { get; set; }
        public string Name { get; set; }
        public string PlanName { get; set; }
        public string Status { get; set; }
        public string MobileNo { get; set; }
        public DateTime? DateTime { get; set; }
    }
    #endregion

}
