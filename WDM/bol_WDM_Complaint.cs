using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_Complaint
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? ServiceType { get; set; }
        public string? BillingArea { get; set; }
        public string? CustAccNo { get; set; }
        public string? Name { get; set; }
        public string? PhoneNo { get; set; }
        public string OtherPhoneNo { get; set; }
        public string? ComplaintID { get; set; }
        public string? Remark { get; set; }
        public bool? IsSolved { get; set; }
        public DateTime? SolvedDate { get; set; }
        public string? SolvedBy { get; set; }
        public string? StaffRemark { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string? FormattedCreatedDate { get; set; }
        public string? FormattedSolvedDate { get; set; }


        public string? Desc_eng { get; set; }
        public string? Desc_mm { get; set; }

        public string? SearchText { get; set; }

        public string Source { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }


        public string StaffID { get; set; }

        public int PageIndex { get; set; }

    }
}
