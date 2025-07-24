using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOL.Resources
{
   public class bol_Resources_HowTo
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Title_Eng { get; set; }
        public string Description_Eng { get; set; }
        public string Title_MM { get; set; }
        public string Description_MM { get; set; }
        public string RelatedPost_Image { get; set; }
        public bool IsActive { get; set; }
        public bool changefilephoto { get; set; }
        public int SortOrder { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public int HowToCount { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CategoryName_MM { get; set; }
        public string CategoryName_Eng { get; set; }
        public string photoName { get; set; }
        //public int HowToID { get; set; }
        public HttpPostedFileBase photos { get; set; }
        public string SearchText { get; set; }
        public int PageSkipsRows { get; set; }
        public int PageTakeRows { get; set; }
    }

    public class bol_Resources_HowToImage
    {
        public int ID { get; set; }
        public int HowToID { get; set; }
        public int GroupID { get; set; }
        public string ImagesUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
