using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.StaffDetails
{
    public class bol_StaffDetails
    {
        public int ActionParam { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string customerAccountNumber { get; set; }
        public string Owner { get; set; }
        public string POS_ExternalId { get; set; }
        public string UpdatedBy { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public int TeamID { get; set; }
    }
    public class bol_StaffDetails_Progress
    {
        public int AllCount { get; set; }
        public int HaveStaffIDCount { get; set; }
        public int CurrentProgress { get; set; }
    }
    public class bol_GetStaffData
    {
        public string username { get; set; }
        public string fullName { get; set; }
        public string externalId { get; set; }
        public int TeamID { get; set; }
        public bool IsSetOwner { get; set; }
    }

    public class bol_StaffLoginHistory
    {
        public string userName { get; set; }
        public string loginDate { get; set; }
        public string logoutDate { get; set; }
        public string status { get; set; }
        public int ActionParam { get; set; }
    }
}
