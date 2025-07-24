using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CF
{
   public class bol_CF_CollectForm_Staff
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string LeadAssignDepartmentID { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public bool IsSuperAdmin { get; set; }
        public bool IsDepartmentAdmin { get; set; }
    }

    public class bol_CF_CollectForm_Staf_CityTownship
    {
        public bool CityActive { get; set; }
        public int City_ID { get; set; }
        public bool TSActive { get; set; }
        public int Township_ID { get; set; }
        public string CityName { get; set; }
        public string TownshipName { get; set; }
        public string StaffCounts { get; set; }
        public string StaffNames { get; set; }
        public string StaffBind { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsChkListPermission { get; set; }
    }

    public class bol_CF_CollectForm_Staff_Model
    {
        public int ActionParam { get; set; }
        public int CityID { get; set; }
        public string TownshipID { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsChkListPermission { get; set; }
        public string SearchText { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentID { get; set; }
        public string LeadAssignDepartmentID { get; set; }
        public string CreatedBy { get; set; }
    }

    public class bol_CF_GetAllStaffChkPermission_Model
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }
    }
}
