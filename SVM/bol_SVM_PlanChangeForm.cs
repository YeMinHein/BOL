using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.SVM
{
    public class bol_SVM_PlanChangeForm
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? EmailAddress { get; set; }
        public string? CustAccNo { get; set; }
        public string? Name { get; set; }
        public int? CurrentUsingPlanID { get; set; }
        public string? CurrentUsingServicePlan { get; set; }
        public int? ToChangePlanID { get; set; }
        public string? ToChangeServicePlan { get; set; }
        public string? CustPhoneNo { get; set; }
        public string? Date { get; set; }        
        public string? CreatedDate { get; set; }
        public string? BillingArea { get; set; }
        public bool? lstIsSolved { get; set; }
        public bool? IsSolved { get; set; }
        public DateTime? SolvedDate { get; set; }
        public string? SolvedBy { get; set; }
        public string? StaffRemark { get; set; }
        public string? FormattedCreatedDate { get; set; }
        public string? FormattedSolvedDate { get; set; }       
        public string? SearchText { get; set; }
        public string effectiveDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string source { get; set; }
        public int PageIndex { get; set; }
        public string StaffID { get; set; }
    }
}
