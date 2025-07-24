using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.General
{
    public class bol_DPSI_ServicePlan
    {
        public int ActionParam { get; set; }
        public string ServiceName { get; set; }
        public int ServicePlansID { get; set; }
        public string ServicePlan { get; set; }
        public string ServicePlanFullName { get; set; }
        public bool IsAlone { get; set; }
    }
}
