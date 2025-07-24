using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.NOTI
{
    public class bol_NOTI_Template
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? AppID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Type { get; set; }
        public string? SubType { get; set; }
        public string? SubTypeName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? SearchText { get; set; }
        public int PageIndex { get; set; }

        public string PromoUrl { get; set; }
        public string InfoImageUrl { get; set; }
        public string Category { get; set; }
        public string templateDescription { get; set; }
    }

    public class bol_NOTI_TemplateV2
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? AppID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Type { get; set; }
        public string? SubType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? SearchText { get; set; }
        public int PageIndex { get; set; }
        public string PromoImageUrl { get; set; }
        public string TxnImageUrl { get; set; }
        public string InfoImageUrl { get; set; }
        public string PromoUrl { get; set; }
        public string BodyDetail { get; set; }
        public string Category { get; set; }
        public string IDType { get; set; }
    }
}
