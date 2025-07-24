using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.General
{
    public class bol_ExportExcelLog
    {
        public int ActionParam { get; set; }
        public string Form { get; set; }
        public string SearchFromDate  { get; set; }
        public string SearchToDate  { get; set; }
        public string Filter  { get; set; }
        public string SearchBy  { get; set; }
        public string SearchDate { get; set; }
    }
}
