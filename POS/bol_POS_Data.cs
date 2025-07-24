using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.POS
{
    public class bol_POS_Data
    {
        public int ID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int SalesCount { get; set; }
        public string City { get; set; }
        public string Plan { get; set; }
        public string FTTHCategory { get; set; }
        public bool IsAllTotal { get; set; }
        public bool IsOnlyCondoSales { get; set; }
        public bool IsOnlyBusinessPlan { get; set; }
        public string colorCode { get; set; }
        public int ActionParam { get; set; }
        public int SortOrder { get; set; }
    }
    public class bol_POS_WeeklyReport
    {
        public int ActionParam { get; set; }
        public string Week { get; set; }
        public int Counts { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

    }
    public class bol_POS_MontlyReport
    {
        public int ActionParam { get; set; }
        public string MonthYearByNo { get; set; }
        public string MonthYearByText { get; set; }
        public int Counts { get; set; }
    }
    public class bol_POS_SalesByCity
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string PlanName { get; set; }
        public int SalesCount { get; set; }
    }
    public class bol_POS_last31Sales
    {
        public int ID { get; set; }
        public string DayNames { get; set; }
        public int SalesCount { get; set; }
    }
    public class bol_POS_last12MonthSales
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public Double SalesPrice { get; set; }
    }

    public class bol_POS_SalesByCityList
    {
        public List<bol_POS_SalesByCity> MonthlyTotal { get; set; }
        public List<bol_POS_SalesByCity> DateRangeTotal { get; set; }
    }

    public class bol_POS_CrawlTime
    {
        public int ID { get; set; }
        public string CrawlTime { get; set; }
    }


}
