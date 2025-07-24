using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.PROMO
{
   public class bol_ServiceBasePlan_Setup
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
