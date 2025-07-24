using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.SVM
{
    public class bol_SVM_ReactivateForm
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? EmailAddress { get; set; }
        public string? CustomerAccountNo { get; set; }
        public string? CustomerName { get; set; }       
        public string? CustContactPhoneNo { get; set; }
        public string? EnableDate { get; set; }        
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
        public int PageIndex { get; set; }
        public string StaffID { get; set; }
        public string source { get; set; }
    }
}
