using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WebNoti
{
    public class bol_WebNOTI_Param
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Noti_SubTypeID { get; set; }
        public string? ParamText { get; set; }
        public string? ParamValue { get; set; }
        public string? Description { get; set; }
    }

    public class bol_WebNOTI_ReplaceParam
    { 
        public int ActionParam { get; set; }
        public string? ParamType { get; set; }
        public string? Param { get; set; }
    }
}
