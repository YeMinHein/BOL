using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.URM
{
    public class bol_URM_Setup
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? userName { get; set; }
        public string departmentName { get; set; }
        public string? password { get; set; }
        public string? fullName { get; set; }
        public string? mobileNo { get; set; }
        public string? email { get; set; }
        public string? status { get; set; }
        public bool? IsActive { get; set; }        
        public string? is_POS_Staff { get; set; }
        public DateTime? CreatedDate { get; set; }
       public int? RegionID { get; set; }
        public string? role { get; set; }
        public string? roleName { get; set; }
        public bool? isSuperAdmin { get; set; }
        public bool? isDepartmentAdmin { get; set; }
        public string? BillingArea { get; set; }
        public string? SearchText { get; set; }
        public string[]? RegionName { get; set; }
        public string? newpassword { get; set; }
        public string? userrole { get; set; }
        public int PageIndex { get; set; }
        public string POS_ExternalId { get; set; }
        public string SearchIsActive { get; set; }
        public string ModifyBy { get; set; }
        public int? employeeID { get; set; }
        public DateTime? joinDate { get; set; }
        public DateTime? resignDate { get; set; }
        public string? location { get; set; }
        public string? city { get; set; }
        public string? slackID { get; set; }
        public string? position { get; set; }
        public string? team { get; set; }
        public string? joinDatestring { get; set; }
        public string? resignDatestring { get; set; }
    }

    public class bol_App_Role 
    {
        public int ActionParam { get; set; }
        public string App { get; set; }
        public string userName { get; set; }
    }

}
