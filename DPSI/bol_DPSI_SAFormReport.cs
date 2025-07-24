using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.DPSI
{
    public class bol_DPSI_SAFormReport
    {
        public int ActionParam { get; set; }
        public string MonthYearByNo { get; set; }
        public string MonthYearByText { get; set; }
        public int Counts { get; set; }
    }

    public class bol_DPSI_SAFormWeeklyReport
    {
        public int ActionParam { get; set; }
        public string Week { get; set; }
        public int Counts { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

    }
}
