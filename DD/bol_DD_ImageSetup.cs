using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.DD
{
    public class bol_DD_ImageSetup
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? ImageType { get; set; }
        public string? ImageUrl { get; set; }
        public string? BillingArea { get; set; }
        public string? Description { get; set; }
        public string? LearnMoreUrl { get; set; }
        public bool? IsActive { get; set; }
        public string? ImageFileName { get; set; }
        public int PageIndex { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
