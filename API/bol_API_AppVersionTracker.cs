using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_AppVersionTracker
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string AppID { get; set; }
        public string AppVersion { get; set; }
        public bool IsForceToUpdate { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }

    public class bol_API_AppVersionTrackerDetail
    {
        public string AppID { get; set; }
        public string AppVersion { get; set; }
        public bool IsForceToUpdate { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
