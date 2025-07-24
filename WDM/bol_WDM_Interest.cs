using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
   public class bol_WDM_Interest
    {
        public int actionParam { get; set; }
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public string SearchText { get; set; }
        public int ServiceBasePlanID { get; set; }
        public string ServicePlan { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Township { get; set; }
        public string City { get; set; }
        public int TownshipId { get; set; }
        public int CityId { get; set; }
        public string FormattedCreatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Category { get; set; }
        public int PageSkipRows { get; set; }
        public int PageTakeRows { get; set; }
    }
}
