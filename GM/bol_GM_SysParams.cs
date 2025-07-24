using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.GM
{
    public class bol_GM_SysParams
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? KeyName { get; set; }
        public string? KeyValue { get; set; }
        public string? Description { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }

        public string? SearchText { get; set; }
        public int PageIndex { get; set; }
    }
}
