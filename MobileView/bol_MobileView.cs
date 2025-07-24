using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.MobileView
{
    public class bol_MobileViewList
    {
        public int ActionParam { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
    public class bol_MobileViewListResModel
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
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
        public string TotalCharges { get; set; }
        public double PlanAmount { get; set; }
        public double TaxAmount { get; set; }
        public int SurchargePercentage { get; set; }
        public string PaymentOperator { get; set; }
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
        public string ODSOwner { get; set; }
        public string LastRemark { get; set; }

    }

    public class bol_MobileView_Detail
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? ServicePlan { get; set; }
        public string? PromoPlan { get; set; }
        public string? TotalAmount { get; set; }
        public string? MonthlyAmount { get; set; }
        public string? CreatedDate { get; set; }
        public List<bol_MobileView_Detail> MVDetailList { get; set; }
        public string? Duration { get; set; }
        public string? MRCTotal { get; set; }
    }
}
