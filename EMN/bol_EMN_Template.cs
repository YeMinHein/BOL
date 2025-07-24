using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.EMN
{
    public class bol_EMN_Template
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Type { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? SearchText { get; set; }
        public string? SubType { get; set; }
        public int? TypeID { get; set; }
        public int PageIndex { get; set; }
        public string? FromEmailAddress { get; set; }
        public string? FromEmailPassword { get; set; }
        public string? ReminderType { get; set; }
    }
    public class bol_EMN_Temp_Attached
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? AttachedFile { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }        
        public string? FormattedCreatedDate { get; set; }
    }
}
