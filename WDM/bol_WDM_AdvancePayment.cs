using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.WDM
{
    public class bol_WDM_AdvancePayment
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
        public string? CreatedDate { get; set; }
        public string? FormattedCreatedDate { get; set; }
        public string?  ServicePlan { get; set; }
        public string? PromoName { get; set; }
        public int? FOCMonth { get; set; }
        public int? FOCDay { get; set; }
        public int? InstallMonth { get; set; }
        public int? Price { get; set; }

        public string IsSurchargeOn { get; set; }
        public string TaxPercentage { get; set; }
        public string TaxAmount { get; set; }
        public string Amount { get; set; }
        public string? TotalAmount { get; set; }
        public string? SearchText { get; set; }
        public string? PromoPlan { get; set; }
        public string? BillingArea { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int PageIndex { get; set; }
        public string OrderCode { get; set; }
        public string LastStatus { get; set; }
        public string LastLoggedBy { get; set; }
        public string LastLoggedDate { get; set; }
        public int? LastStatusID { get; set; }
        public string LastStatusParentName { get; set; }
        public string LastStatusName { get; set; }
        public string Status { get; set; }
        public string ColorCode { get; set; }
        public string? Source { get; set; }
        public bool? IsFinished { get; set; }

        public DateTime? FinishedDate { get; set; }
        public string? FinishedBy { get; set; }
        public string? PaymentBy { get; set; }
        public string? PaymentDate { get; set; }

        public string? FinishedRemark { get; set; }
        public string? FormattedFinishedDate { get; set; }
        public string? ShowRoomName { get; set; }
        public bool SendReceipt { get; set; }
        public string UserName { get; set; }

    }
    public class bol_ServiceBasePlanSurchargeModel
    {
        public int ActionParam { get; set; }
        public string? CurrentPlan { get; set; }

        public int ID { get; set; }
        public bool IsSurchargeOn { get; set; }
        public decimal SurchargePercentage { get; set; }
    }
    public class bol_AdvancePaymentStatusModel
    {
        public int ID { get; set; }
        public int? ActionParam { get; set; }
        public string Remark { get; set; }
        public int Status_ID { get; set; }
        public int? SA_ID { get; set; }
        public string LoggedBy { get; set; }
        public DateTime LoggedDate { get; set; }
        public string LoggedDateStr { get; set; }
        public int ParentGroupID { get; set; }
        public string Step { get; set; }
        public string StepStatus { get; set; }
        public string Status { get; set; }
        public string StatusName { get; set; }
        public string StatusColorCode { get; set; }
        public string PaymentAlias { get; set; }
        public bool SendReceipt { get; set; }
        public string PaymentDocumentNo { get; set; }
        public string OrderCode { get; set; }
        public string FinishedRemark { get; set; }
    }

}
