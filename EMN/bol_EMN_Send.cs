using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.EMN
{
    public class bol_EMN_Send
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Type { get; set; }
        public string? SubType { get; set; }
        public string? TemplateID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public int Records { get; set; }
        public string EMNReminderType { get; set; }
    }

    public class bol_EMN_Progress
    {
        public int ActionParam { get; set; }
        public int? EMNSendID { get; set; }
        public string? Type { get; set; }
        public int? SubTypeID { get; set; }
        public int? TemplateID { get; set; }
        public int? Records { get; set; }
        public string? SubType { get; set; }
        public string? Name { get; set; }
        public string? Message { get; set; }
        public int? ProgressRecords { get; set; }
        public string? Template { get; set; }
        public int? CompleteRecords { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string? FormattedCreatedDate { get; set; }
        public string? FormattedCompletedDate { get; set; }
    }
}
