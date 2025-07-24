using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_RegionList
    {
        public int? ID { get; set; }
        public int? RegionID { get; set; }
        public int? ActionTypeID { get; set; }
        public string? Region { get; set; }
        public string? ActionType { get; set; }
        public string? PrimaryPhoneNo { get; set; }
        public string? SecondaryPhoneNos { get; set; }
        public string? PrimaryEmail { get; set; }
        public string? CCEmails { get; set; }
        public string? BCCEmails { get; set; }
        public string? Address { get; set; }
        public string? LatAndLong { get; set; }
        public string? Facebook { get; set; }
        public string? Youtube { get; set; }
        public string? ShowRoomName { get; set; }
    }
}
