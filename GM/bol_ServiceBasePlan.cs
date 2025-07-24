using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.GM
{
    public class bol_ServiceBasePlan
    {
        public int ID { get; set; }
        public string ServiceType { get; set; }
        public string PlanName { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public decimal? DownloadSpeed { get; set; }
        public decimal? UploadSpeed { get; set; }
        public decimal? InstallationFees { get; set; }
        public string Bandwidth_Megabytes { get; set; }
        public string Features { get; set; }
        public decimal? Price { get; set; }
        public int? BasePlan { get; set; }
        public string Category { get; set; }
        public decimal? DepositAmount { get; set; }
        public string planId { get; set; }
        public string PlanType { get; set; }
        public int? Validity { get; set; }
        public int? PromoDay { get; set; }
        public string ChargingPattern { get; set; }
        public string PkgDisplayName { get; set; }
        public bool IsDisplayinApp { get; set; }
        public bool IsDisplayin5BB { get; set; }
        public bool IsDisplayinSpectrum { get; set; }
        public bool IsSurcharge { get; set; }
        public bool IsParent { get; set; }
        public decimal SurchargePercentage { get; set; }

    }
}
