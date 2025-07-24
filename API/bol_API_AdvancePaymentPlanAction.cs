using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_AdvancePaymentPlanAction
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? AdvancePaymentForMonths { get; set; }
        public string? CustomerAccountNo { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNo { get; set; }
        public string? Email { get; set; }
        public string? CurrentPlan { get; set; }
        public string? BankForPayment { get; set; }        
        public string OrderCode { get; set; }
        public string? TotalAmount { get; set; }
        public string? Source { get; set; }
        public string? ActionType { get; set; }
    }
}
