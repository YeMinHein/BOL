using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Resources
{
   public class bol_Resources_FAQ
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Question_MM { get; set; }
        public string Question_Eng { get; set; }
        public string Answer_MM { get; set; }
        public string Answer_Eng { get; set; }
        public bool IsActive { get; set; }
        public bool IsTopQuestion { get; set; }
        public int TopQSortOrder { get; set; }
        public int SortOrder { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public int FAQCount { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CategoryName_MM { get; set; }
        public string CategoryName_Eng { get; set; }
        public string Tags { get; set; }
        public string SearchText { get; set; }
        public int PageSkipsRows { get; set; }
        public int PageTakeRows { get; set; }
    }
}
