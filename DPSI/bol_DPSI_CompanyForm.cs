using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOL.DPSI
{
    public class bol_DPSI_CompanyForm
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
    }
    
}
