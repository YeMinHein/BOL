using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.EvoNoti
{
  public  class bol_Evo_NOTI_Template
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

    public class Evo_NOTI_Tmp_Search_Req_Model
    {
        [DisplayName("Search : ")]
        [DataType(DataType.Text)]
        public string? SearchText { get; set; }

        [DisplayName("Type")]
        [DataType(DataType.Text)]
        public string Type { get; set; }

        [DisplayName("SubType")]
        [DataType(DataType.Text)]
        public string SubType { get; set; }
        public int PageIndex { get; set; }
    }
    public class bol_Evo_NOTI_TemplateV2
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
        public bool? IsDefault { get; set; }
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
        public string templateDescription { get; set; }
    }
    public class bol_Evo_TopicType
    {
        public int ActionParam { get; set; }
        public string TopicType { get; set; }
        public string Topic { get; set; }
    }

    public class bol_Evo_Topic
    {
        public int ActionParam { get; set; }
        public string TopicType { get; set; }
        public string Topic { get; set; }
        public int CityID { get; set; }
    }

    public class bol_Evo_Template
    {

    }

    #region noti send
    public class bol_Evo_NOTI_Param
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Noti_SubTypeID { get; set; }
        public string? ParamText { get; set; }
        public string? ParamValue { get; set; }
        public string? Description { get; set; }
    }

    public class bol_Evo_NOTI_ReplaceParam
    {
        public int ActionParam { get; set; }
        public string? ParamType { get; set; }
        public string? Param { get; set; }
    }
    #endregion
}
