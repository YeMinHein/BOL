using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CF
{
    public class bol_CF_CollectForm_List_Model
    {
        public int ActionParam { get; set; }
        public string SearchText { get; set; }
        public string Collect_from { get; set; }
        public string Leads_source{ get; set; }
        public string Leads_status{ get; set; }
        public string From_Date{ get; set; }
        public string To_Date{ get; set; }
        public string UserName{ get; set; }
        public bool IsSuperAdminRole { get; set; }
        public bool IsNoOwner { get; set; }
        public string SearchUsername { get; set; }
        public string CFOthers { get; set; }
        public string CFInterested { get; set; }
        public bool TownshipInspection { get; set; }
        public bool IsOnlyMe { get; set; }
        public string ownerName { get; set; }
        public int City_ID { get; set; }
        public int Township_ID { get; set; }
        public int LeadStatusID { get; set; }
        public int ReasonID { get; set; }
        public int StatusID { get; set; }
        public int PageSkipRows { get; set; }
        public int PageTakeRows { get; set; }
    }
    public class bol_CF_CollectForm_List
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string ColorCode { get; set; }
        public string city { get; set; }
        public string township { get; set; }
        public int City_ID { get; set; }
        public int Township_ID { get; set; }
        public string customer_township { get; set; }
        public string address { get; set; }
        public string house_hold_type { get; set; }
        public string collect_from { get; set; }
        public string messenger_user_id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FormattedCreated { get; set; }
        public string FormattedUpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool TownshipInspection { get; set; }
        public bool IsSuperAdminRole { get; set; }
        public string CFOthers { get; set; }
        public string CFInterested { get; set; }


        public int lead_status_id { get; set; }
        public int status_id { get; set; }
        public int reason_id { get; set; }
        public int other_operator_used_id { get; set; }
        public string assign_staff_name { get; set; }
        public string remark { get; set; }
        public string ownerName { get; set; }
        public string leadstatusName { get; set; }
        public string statusName { get; set; }
        public string reasonName { get; set; }
        public string otherOperatorName { get; set; }
    }

    public class bol_CF_CollectForm_Status
    {
        public int ActionParam { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int ID { get; set; }
        public int GroupID { get; set; }
        public int ParentGroupID { get; set; }
        public string ColorCode { get; set; }
    }

    public class bol_CF_CollectForm_Update
    {
        public int ActionParam { get; set; }
        public int ID { get; set; } 
        public int lead_status_id { get; set; }
        public int status_id { get; set; }
        public int reason_id { get; set; }
        public int other_operator_used_id { get; set; }
        public string assign_staff_name { get; set; }
        public string remark { get; set; }
        public string CreatedBy { get; set; }
    }
}
