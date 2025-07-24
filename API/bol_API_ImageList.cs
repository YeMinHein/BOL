using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_ImageList
    {
        public int ID { get; set; }
        public string BillingArea { get; set; }
        public string ImageType { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string LearnMoreUrl { get; set; }
    }
}
