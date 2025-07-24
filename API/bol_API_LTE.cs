using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_LTE
    {
    }

    public class bol_API_LTE_GetBillingAreaID
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string Alias { get; set; }

    }
    public class bol_API_LTE_GetPlanInfo
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string planName { get; set; }

    }
    public class bol_API_LTE_GetRechargePlan
    {
        public int ActionParam { get; set; }
        public string CustAccNo { get; set; }
        public string planID { get; set; }
        public string planName { get; set; }
        public string FullName { get; set; }
        public int CalculatePrice { get; set; }
        public string Price { get; set; }
        public int SortOrder { get; set; }
        public string DownloadSpeed { get; set; }
        public string UploadSpeed { get; set; }
        public int Quota { get; set; }
        public int Validity { get; set; }

    }

    public class bol_API_LTE_GetRechargePlan_ResModel
    {
        public string planID { get; set; }
        public string planName { get; set; }
        public string FullName { get; set; }
        public int CalculatePrice { get; set; }
        public string Price { get; set; }
        public int SortOrder { get; set; }
        public string DownloadSpeed { get; set; }
        //public string UploadSpeed { get; set; }
        public int Quota { get; set; }
        public int Validity { get; set; }
        public string Label { get; set; }


    }

    public class bol_API_LTE_GetPlanName
    {
        public int ActionParam { get; set; }
        public string planId { get; set; }
        public string PlanName { get; set; }

    }
}
