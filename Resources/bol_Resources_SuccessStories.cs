using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOL.Resources
{
  public class bol_Resources_SuccessStories
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string IndustryName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Logo { get; set; }
        public string BannerPhoto { get; set; }
        public HttpPostedFileBase photos { get; set; }
        public HttpPostedFileBase banner_Photos { get; set; }
        public string Title { get; set; }
        public string Regions { get; set; }
        public string BriefDescription { get; set; }
        public bool changefilephoto { get; set; }
        public bool changebannerfilephoto { get; set; }
        public string companyName { get; set; }
        public string Description { get; set; }
        public string CustomerSatisfiedDate { get; set; }
        public string Oraganizationsize { get; set; }
        public string json_BriefSpeechListArrlist { get; set; }
        public string json_SpeechListArrlist { get; set; }
        public string Websites { get; set; }
        public string CompanyProducts { get; set; }
        public int PageSkipsRows { get; set; }
        public int PageTakeRows { get; set; }
        public string SearchText { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public string photoName { get; set; }
        public string bannerphotoName { get; set; }
        public string FormattedCreatedDate { get; set; }
    }

    public class bol_Resources_Industry
    {
        public int ID { get; set; }
        public string IndustryName { get; set; }
        public string BriefDescription { get; set; }
        public string Photo { get; set; }
    }
    public class bol_Resources_Region
    {
        public int ID { get; set; }
        public string RegionName { get; set; }       
    }

    public class bol_Resources_CompanySize
    {
        public int ID { get; set; }
        public string CompanySize { get; set; }
    }

    public class bol_Resources_Speech
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public string Name { get; set; }
        public string SpeechText { get; set; }
        public string Position { get; set; }
        public string GenerateName { get; set; }
        public string ActionTypes { get; set; }
        public string DepartmentName { get; set; }
        public string CheckIDs { get; set; }
        public string CreatedBy { get; set; }
    }
}
