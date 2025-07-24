using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.URM
{
    public class bol_URM_Role_Menu
    {
        //public int ID { get; set; }
        public int? ChildId { get; set; }
        public string Title { get; set; }
        // public int? Generation { get; set; }
        public int? ParentID { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string SortOrder { get; set; }
        public string Icon { get; set; }
        public bool IsCheck { get; set; }
        public int? ActionParam { get; set; }
        public int? RoleID { get; set; }
        public int MenuLevel { get; set; }
        public string MenuList { get; set; }
        public string UpdatedBy { get; set; }
        public string ParentMenuName { get;set;}
        public string userName { get; set; }
        public bool IsActive { get; set; }
        public bool IsTopNav { get; set; }
        public bool ? IsCodeLevel { get; set; }
    }
}
