using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_ODSMap
    {
        public int ActionParam { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
    }

    public class bol_WDM_ODS_ResModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Type { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string BatteryPercentage { get; set; }
        public string CreatedDate { get; set; }
        public string ActionID { get; set; }
    }
    public class bol_WDM_ODS_LatLongResModel
    {
        public decimal lat { get; set; }
        public decimal lng { get; set; }
        public int label { get; set; }
    }
    public class bol_WDM_GPS_UserList
    {
        public string UserName { get; set; }
    }
    public class bol_WDM_GPS_Calculate
    {
        public string userName { get; set; }
        public string TotalDurationSeconds { get; set; }
        public string OnOffTotalDuration { get; set; }
    }

}
