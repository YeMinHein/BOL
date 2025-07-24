using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WebNoti
{
   public class bol_WebNOTI_User_Devices
    {
        public int ActionParam { get; set; }
        public string Device_ID { get; set; }
        public string Device_Token { get; set; }
        public string UserName { get; set; }

        public string BrowserName { get; set; }

        public string BrowserFullVersion { get; set; }

        public string UserOSName { get; set; }
        public string StaffName { get; set; }
        public int UnReadCount { get; set; }
    }
}
