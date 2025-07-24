using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_Account
    {
        public string UrlAddress { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string GrantType { get; set; }

        public string BasicUserName { get; set; }
        public string BasicPassword { get; set; }

        public string Authorization { get; set; }
    }

    public class bol_API_StaffAccount
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }
        public string POS_userName { get; set; }
        public string POS_PWD { get; set; }
    }
}
