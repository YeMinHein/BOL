using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOL.DPSI
{
    public class bol_DPSI_ContactForm
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public int? CompanyID { get; set; }
        public string? Title { get; set; }
        public string ContactPersonName { get; set; }
        public string DOB { get; set; }
        public string? NRCPassport { get; set; }
        public string? Designation { get; set; }
        public string? Department { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailAddress { get; set; }
        public string? Note { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedDate { get; set; }
        public string? CompanyName { get; set; }
        public string? SearchText { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int PageIndex { get; set; }
        public string Owner { get; set; }
        public bool? IsOnlyMe { get; set; }
        public bool IsDepartmentAdmin { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string UserName { get; set; }

    }
   
}
