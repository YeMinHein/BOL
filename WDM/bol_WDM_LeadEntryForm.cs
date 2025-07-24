using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_LeadEntryForm
    {
       
    }

    public class bol_WDM_LEF_City
    {
        public int ActionParam { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
    }

    public class bol_WDM_LEF_Township
    {
        public int ActionParam { get; set; }
        public int CityID { get; set; }
        public int TownshipID { get; set; }
        public string Township { get; set; }
    }
    public class bol_WDM_LEF_ChargingPattern
    {
        public int ActionParam { get; set; }
        public string ChargingPattern { get; set; }
    }

    public class bol_WDM_LEF_Category
    {
        public int ActionParam { get; set; }
        public string ChargingPattern { get; set; }
        public string Category { get; set; }
    }

    public class bol_WDM_LEF_Channel
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string Channel { get; set; }
    }
    public class bol_WDM_LEF_Plan
    {
        public int ActionParam { get; set; }
        public int CityID { get; set; }
        public string Category { get; set; }
    }
    public class bol_WDM_ServiceBasePlan
    {
        public int id { get; set; }
        public string service_type { get; set; }
        public string plan_name { get; set; }
        public string plan_full_name { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
        public bool isShown { get; set; }
        public decimal download_speed { get; set; }
        public decimal upload_speed { get; set; }
        public int sortOrder { get; set; }
        public string features { get; set; }
        public decimal price { get; set; }
        public string created_date { get; set; }
        public string created_user_id { get; set; }
        public string updated_date { get; set; }
        public string updated_user_id { get; set; }
        public string TotalCharges { get; set; }
        public bool IsSurchargeOn { get; set; }
        public string TaxAmount { get; set; }

        public double SurchargePercentage { get; set; }
        public string Price { get; set; }
        public string Bandwidth_Megabytes { get; set; }
        public string DownloadUnit { get; set; }
    }
}
