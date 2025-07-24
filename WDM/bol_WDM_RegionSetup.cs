using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_RegionSetup
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? ServiceType { get; set; }
        public string? RegionName { get; set; }
        public string? Prefix { get; set; }
        public string? City { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }

        public string? SearchText { get; set; }
        public int PageIndex { get; set; }
    }
}
