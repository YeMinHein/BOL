using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
   public class bol_WDM_GuestContactUs
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string CreatedDate { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string AssignedStatus { get; set; }
        public string AssignedGroup { get; set; }
        public int ? PageSkipRows { get; set; }
        public int ? PageTakeRows { get; set; }
    }

    public class bol_WDM_GuestContactUs_Status
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int GuestContact_ID {get;set;}
        public string Status { get; set; }
        public string AssignedGroup { get; set; }
        public string Remark { get; set; }
        public string LoggedBy { get; set; }
        public DateTime LoggedDate { get; set; }
        public string LoggedDateStr { get; set; }
    }
}
