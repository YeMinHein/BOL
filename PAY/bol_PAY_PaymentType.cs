using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.PAY
{
   public class bol_PAY_PaymentType
    {
        public int actionParam { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string PaymentAlias { get; set; }
    }

    public class bol_PAY_PaymentMethod
    {
        public int actionParam { get; set; }
        public int ID { get; set; }
        public string BankName { get; set; }
        public string Value { get; set; }
        public string Status { get; set; }
        public bool IsInitial { get; set; }
    }
}
