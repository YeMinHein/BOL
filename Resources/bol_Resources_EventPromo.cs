using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOL.Resources
{
    public class bol_Resources_EventPromo
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BriefDescription { get; set; }
        public string RelatedPost_Image { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string ImageListID { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublish { get; set; }
        public bool IsFeatured { get; set; }
        public int SortOrder { get; set; }
        public string TopicID { get; set; }
        public string SearchText { get; set; }
        public string TopicNames { get; set; }
        public string TopicIDs { get; set; }
        public string Blog_ID { get; set; }
        public string AuthorNames { get; set; }
        public string PublishStatus { get; set; }
        public string AuthorIDs { get; set; }
        public bool changefilephoto { get; set; }
        public HttpPostedFileBase photos { get; set; }
        public string Status { get; set; }
        public string PostStatus { get; set; }
        public int PageSkipsRows { get; set; }
        public int PageTakeRows { get; set; }
        public string photoName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FormattedCreatedDate { get; set; }
        public string FormattedPublishDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? eventInterestForm { get; set; }

    }

    public class bol_Resources_EventPromoImage
    {
        public int ID { get; set; }
        public int BlogID { get; set; }
        public string ImagesUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string imgSrc { get; set; }
        public HttpPostedFileBase upload { get; set; }
    }
    public class bol_Resources_EventPromoTopic
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class bol_Resources_EventPromoAuthor
    {
        public int ID { get; set; }
        public string AuthorName { get; set; }
    }
}
