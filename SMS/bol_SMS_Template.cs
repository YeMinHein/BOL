using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.SMS
{
    public class bol_SMS_Template
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Message { get; set; }
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
        public string? MobileNo { get; set; }
    }
}
