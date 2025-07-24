using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOL.EMN
{
    public class bol_EMN_History
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? ReminderID { get; set; }
        public int? EMNSendID { get; set; }
        public string? CustAccNo { get; set; }
        public string? FromAddress { get; set; }
        public string? ToAddress { get; set; }
        public string BCCAddress { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ActivityTypeID { get; set; }
        public DateTime? SendDate { get; set; }
        public string? CCAddress { get; set; }
        public string? SubType { get; set; }
        public string? Status { get; set; }
        public int PageIndex { get; set; }
        public string PaymentDocumentNo { get; set; }
        public string ReminderFailDate { get; set; }
        public int ExcelNo { get; set; }
        public HttpPostedFileBase[] attachedfiles { get; set; }
    }

}
