using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_SaveActivityLog
    {
        public string? CustomerAccountNo { get; set; }
        public string? Description { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string? ActivityType { get; set; }
    }
    public class bol_API_CustomerComplaintModel
    {

        public string CustomerAccountNo { get; set; }
        public string Description { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string ActivityType { get; set; }
        public string Source { get; set; }
        public string ServiceType { get; set; }
        public string ComplaintDesc { get; set; }

    }
    public class bol_API_CustomerRelocationPlanchangeModel
    {
        public string CustomerAccountNo { get; set; }
        public string ActivityType { get; set; }
        public string ServiceType { get; set; }
        public string EffectiveDate { get; set; }
        public string Source { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }

}
