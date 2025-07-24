using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class bol_Enum
    {
        public enum enum_module
        {
            General = 1,
            Account = 2,
            NOTI = 3,
            WDM = 4,
            DD = 5,
            GM = 6,
            EMN = 7,
            LLK = 8,
            SVM = 9,
            API = 10,
            SMS = 11,
            HBC = 12,
            RFF = 13,
            BS=14,
            DPSI = 15,
            SPS=16
        }

        public enum enum_resp_db
        { 
            Complete = 1,
            Fail = 2,
            Duplicate = 3 
        }

        public enum enum_loglevel
        {
            DEBUG = 1,
            INFO = 2,
            WARN = 3,
            ERROR = 4,
            FATAL = 5
        }


        public enum enum_Status
        {
            Success = 1,
            UserDoesNotExists = 2,
            WrongPassword = 3            
        }

    }
}
