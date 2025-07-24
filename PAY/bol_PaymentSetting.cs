using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.PAY
{
    public  class bol_PaymentSetting
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string ServiceType { get; set; }
        public string PaymentType { get; set; }
        public string PaymentMethod { get; set; }
        public bool IsOpen { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int PageIndex { get; set; }
    }
}
