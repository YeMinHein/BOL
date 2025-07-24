using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_CF_CollectForm
    {
        public int ActionParam { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string township { get; set; }
        public string house_hold_type { get; set; }
        public string address { get; set; }
        public string collect_from { get; set; }
        public string messenger_user_id { get; set; }

        public string interested { get; set; }
        public string other { get; set; }
        public int ID { get; set; }
    }
}
