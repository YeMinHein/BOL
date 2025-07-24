using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_CashCollectorModel { 
        public int ActionParam { get; set; }
        public string userName { get; set; }
        public string fullName { get; set; }
    }
    public class bol_WDM_CashCollectorRequestModel
    {
        public int ActionParam { get; set; }
        public string cityID { get; set; }
        public string userName { get; set; }
        public int pageIndex { get; set; }
    }
    public class bol_WDM_CashCollectorLimitModel
    {
        public int ActionParam { get; set; }
        public int RowNo { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string CityName { get; set; }
        public string CityID { get; set; }
        public string TeamID { get; set; }
        public string TeamName { get; set; }
        public Decimal DailyCashAmount { get; set; }
        public Decimal MaximumAmount { get; set; }
        public Decimal MinimumAmount { get; set; }
        public string Create_Modify_UserName { get; set; }
    }
    public class bol_userNameCashAmount
    {
        public string UserName { get; set; }
        public Decimal DailyCashAmount { get; set; }
    }
    public class bol_WDM_CashCollectorWithSelectRequestModel
    {
        public List<bol_userNameCashAmount> UserList { get; set; }
        public int ActionParam { get; set; }
        public string Create_Modify_UserName { get; set; }
    }
}
