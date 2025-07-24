using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.NOTI
{
    public class bol_NOTI_Send
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Type { get; set; }
        public string? SubType { get; set; }
        public string? TemplateID { get; set; }
        public string? TopicType { get; set; }
        public string? Topic { get; set; }
        public string? Category { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public int Records { get; set; }
    }

    public class bol_NOTI_Progress
    {
        public int ActionParam { get; set; }
        public int? NotiSendID { get; set; }
        public string? Type { get; set; }
        public int? SubTypeID { get; set; }
        public int? TemplateID { get; set; }
        public int? Records { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? SubType { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int? ProgressRecords { get; set; }
        public string? Template { get; set; }
        public int? CompleteRecords { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string? FormattedCreatedDate { get; set; }
        public string? FormattedCompletedDate { get; set; }
    }

    public class bol_NOTI_Send_DeviceListByCustAccNo
    {
        public int ActionParam { get; set; }
        public string? CustAccNo { get; set; }
        public string? DeviceID { get; set; }
    }

    public class bol_NOTI_List
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
    }
}
