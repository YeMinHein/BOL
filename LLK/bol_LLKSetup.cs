using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.LLK
{
    public class bol_LLKSetup
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? MovieType { get; set; }
        public string? MovieName { get; set; }
        public string? ImageUrl { get; set; }
        public string? MovieUrl { get; set; }
        public bool? IsActive { get; set; }
        public string? ImageFileName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int PageIndex { get; set; }
        public string? SearchText { get; set; }
    }
}
