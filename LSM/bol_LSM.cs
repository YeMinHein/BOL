using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BOL.LSM
{
    public class bol_LSM
    {
    }

    public class bol_LSM_GetLTERegionList
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? RegionName { get; set; }
    }

    public class bol_LSM_GetLTEPlanList
    {
        public int ActionParam { get; set; }
        public string? planId { get; set; }
        public string? RechargeId { get; set; }
        public string? PlanName { get; set; }
        public string? LabelColor { get; set; }
        public int? RegionID { get; set; }
        public List<bol_LSM_GetLTEPlanList> lstLTERechargePlan { get; set; }
        public IList<SelectListItem> dataLTERechargePlan { get; set; }
    }

    public class bol_LSM_GetSaveRegionPlanList
    {
        public int ActionParam { get; set; }
        public int? RegionID { get; set; }
        public string? RegionName { get; set; }
        public string? planId { get; set; }
        public string? RechargeId { get; set; }
        public string? PlanName { get; set; }
        public string? LabelColor { get; set; }
        public int PageIndex { get; set; }
        public int ID { get; set; }
        public string Label { get; set; }

    }

    public class bol_LSM_SaveRegionPlanList
    {
        public int ActionParam { get; set; }
        public DataTable udt_LTEPlanSettings { get; set; }
    }
    public class bol_LSM_SaveRechargePlanSetting
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public int RegionID { get; set; }
        public int ServiceBasePlanID { get; set; }
        public string Label { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
    }

    public class bol_LSM_GetLTELabel
    {
        public int ActionParam { get; set; }
        public int? RegionID { get; set; }
        public int? ServiceBasePlanID { get; set; }
        public string? Label { get; set; }
    }
    public class LTERechargePlan_Req_Model
    {
        public int? RegionID { get; set; }
        public int PageIndex { get; set; }
    }
}
