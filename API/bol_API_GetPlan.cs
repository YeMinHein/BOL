using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{

    public class bol_API_ReqGetPlan
    {
        public string? service_type { get; set; }
        public string? plan_full_name { get; set; }
        public string? CustAccNo { get; set; }

    }
    public class bol_API_GetPlan
    {
        public int? ID { get; set; }
        public string? service_type { get; set; }
        public string? plan_short_name { get; set; }
        public string? plan_full_name { get; set; }
        public string? description { get; set; }
        public bool? isActive { get; set; }
        public bool? isShown { get; set; }
        public decimal? download_speed { get; set; }
        public decimal? upload_speed { get; set; }
        public int? sortOrder { get; set; }
        public string? features { get; set; }
        public string? ImageUrl { get; set; }
        public decimal? price { get; set; }
        public decimal? InstallationFees { get; set; }
        public decimal? DepositAmount { get; set; }

        public string? Category { get; set; }
        public string? UploadUnit { get; set; }
        public string? DownloadUnit { get; set; }

        public int? Validity { get; set; }
        public string? ChargingPattern { get; set; }

        public string? PkgDisplayName { get; set; }
    }
}
