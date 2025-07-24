using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_RegionDetail
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public int? RegionID { get; set; }
        public int? ActionTypeID { get; set; }
        public string? PrimaryPhoneNo { get; set; }
        public string? SecondaryPhoneNos { get; set; }
        public string? PrimaryEmail { get; set; }
        public string? CCEmails { get; set; }
        public string? BCCEmails { get; set; }
        public string? Address { get; set; }
        public string? LatAndLong { get; set; }
        public string? Facebook { get; set; }
        public string? Youtube { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }

        public string? RegionName { get; set; }
        public string? ActionTypeName { get; set; }

        public string? ShowRoomName { get; set; }
        public string? SearchText { get; set; }
        public int PageIndex { get; set; }
    }
}
