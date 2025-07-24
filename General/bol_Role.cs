using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.General
{
   
    public class bol_Role
    {
        public int ActionParam { get; set; }
        public string username { get; set; }
        public int ID { get; set; }
        public string Role { get; set; }

    }
    public class bol_SPS_Role
    {
        public int ActionParam { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
    public class bol_SPS_Staff
    {
        public string FullName { get; set; }
        public string MobileNo { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
    }
    public class bol_SPS_CashCollectorData
    {
        public decimal MaximumAmount { get; set; }
        public decimal TodayCollectedCashAmount { get; set; }
    }

}
