using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.URM
{
  public  class bol_URM_Role_Setup: BaseEntity
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSuperAdmin { get; set; }
        public bool  IsActive { get; set; }
        //public string  CreatedBy { get; set; }
        public int PageSkipRows { get; set; }
        public int PageTakeRows { get; set; }
        public string  FieldName { get; set; }
        public string Sort { get; set; }
        public bool IsDepartmentAdmin { get; set; }
        public string SearchText { get; set; }
        public int StaffCount { get; set; }
        public string ValidateActive { get; set; }
    }
}
