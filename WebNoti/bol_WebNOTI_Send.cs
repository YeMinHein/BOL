using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WebNoti
{
    //public class bol_WebNOTI_Send
    //{
    //    public int ActionParam { get; set; }
    //    public int? ID { get; set; }
    //    public string? Type { get; set; }
    //    public string? SubType { get; set; }
    //    public string? TemplateID { get; set; }
    //    public string? TopicType { get; set; }
    //    public string? Topic { get; set; }
    //    public string? Category { get; set; }
    //    public DateTime? CreatedDate { get; set; }
    //    public string? CreatedBy { get; set; }
    //    public int Records { get; set; }
    //}

    //public class bol_WebNOTI_Progress
    //{
    //    public int ActionParam { get; set; }
    //    public int? NotiSendID { get; set; }
    //    public string? Type { get; set; }
    //    public int? SubTypeID { get; set; }
    //    public int? TemplateID { get; set; }
    //    public int? Records { get; set; }
    //    public DateTime? CreatedDate { get; set; }
    //    public string? SubType { get; set; }
    //    public string? Title { get; set; }
    //    public string? Content { get; set; }
    //    public int? ProgressRecords { get; set; }
    //    public string? Template { get; set; }
    //    public int? CompleteRecords { get; set; }
    //    public DateTime? CompletedDate { get; set; }
    //    public string? FormattedCreatedDate { get; set; }
    //    public string? FormattedCompletedDate { get; set; }
    //}

    //public class bol_WebNOTI_Send_DeviceListByCustAccNo
    //{
    //    public int ActionParam { get; set; }
    //    public string? CustAccNo { get; set; }
    //    public string? DeviceID { get; set; }
    //}

    public class bol_WebNOTI_List
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string ToUserName { get; set; }
        public string DetailsUrl { get; set; }
        public string? FormattedCreatedDate { get; set; }
        public bool IsRead { get; set; }
        public string fromUserName { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int PageSkipsRows { get; set; }
        public int PageTakeRows { get; set; }
        public string CreatedBy { get; set; }
        public string NotiHours { get; set; }
        public int AllNotiCount { get; set; }
        public string FireBase_WebNotiServerKey { get; set; }

        //  public string CreatedBy { get; set; }

    }

    public class bol_WebNoti_Send
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int NotiSendID { get; set; }
        public string userName { get; set; }
        public string fromUserName { get; set; }
        public string lstToUserName { get; set; }
        public string CreatedBy { get; set; }
        public string torole { get; set; }
        public int Template_ID { get; set; }
        public string DetailsUrl { get; set; }
        public bool IsFinanceUser { get; set; }
        public bool IsDepartmentAdmin { get; set; }
        public bool IsSuperAdmin { get; set; }
        public bool IsOnlyOneUser { get; set; }
        public bool IsRoleUser { get; set; }
        public string FireBase_WebNotiServerKey { get; set; }
        public int records { get; set; }
        public string[] deviceTokens { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}
