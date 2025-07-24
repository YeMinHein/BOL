using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_ComplaintSetup
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Desc_eng { get; set; }
        public string? Desc_mm { get; set; }
        public string? Remark { get; set; }
        public string? Solution { get; set; }
        public string? ServiceType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? SearchText { get; set; }
        public int PageIndex { get; set; }
    }
}

