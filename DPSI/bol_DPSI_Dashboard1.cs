using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.DPSI
{
    public class bol_DPSI_Dashboard1
    {
        public int ActionParam { get; set; }
        public int CurrentMonthSAFormCounts { get; set; }
        public int CurrentMonthSDFormCounts { get; set; }
    }
    public class bol_DPSI_Dashboard
    {
        public int ActionParam { get; set; }
        public string LeadsConversionRatio { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int Leads { get; set; }
        public int Qualified { get; set; }
        public int Negotiate { get; set; }
        public int SalesWon { get; set; }
        public int ClosedWon { get; set; }
        public int ROWID { get; set; }
        public int RowNo { get; set; }
        public string ConversationRate { get; set; }
        public string TotalCount { get; set; }
        public string MonthlyAmount { get; set; }
        public string TotalAmount { get; set; }
        public string ARPU { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string subscribercount { get; set; }
        public int Inbound { get; set; }
        public int Outbound { get; set; }
        public int IncomingPhoneCall { get; set; }
        public int Messenger { get; set; }
        public int PageComments { get; set; }
        public int WebsiteForms { get; set; }
        public int Instagram { get; set; }
        public int LinkedIn { get; set; }
        public int Telegram { get; set; }
        public int Mailchimp { get; set; }
        public int _5BBBusiness { get; set; }
        public int Globalnet { get; set; }
        public int Referral { get; set; }
        public int OutboundCall { get; set; }
        public string SortBy { get; set; }
        public string saleswonsubscribercount { get; set; }

    }

    public class bol_DPSI_Detail
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? ServicePlan { get; set; }
        public string? PromoPlan { get; set; }
        public string? TotalAmount { get; set; }
        public string? MonthlyAmount { get; set; }
        public string? CreatedDate { get; set; }
        public List<bol_DPSI_Detail> DPSIDetailList { get; set; }
        public string? Duration { get; set; }
        public string? MRCTotal { get; set; }
    }
}
