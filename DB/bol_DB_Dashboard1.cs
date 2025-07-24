using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.DB
{
    public class bol_DB_Dashboard1
    {
        public int ActionParam { get; set; }
        public int CurrentMonthSAFormCounts { get; set; }
        public int CurrentMonthSDFormCounts { get; set; }
    }
    public class bol_BS_Dashboard
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
        public string FullName { get; set; }
        public string Role { get; set; }
        public string subscribercount { get; set; }
        public int ApplicationForm { get; set; }
        public int InterestForm { get; set; }
        public int Ads_InterestForm { get; set; }
        public int AdminPortalForm { get; set; }
        public int AppointmentForm { get; set; }
        public int Import { get; set; }
        public string SortBy { get; set; }
        public string saleswonsubscribercount { get; set; }

    }

    public class bol_BS_Detail
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? ServicePlan { get; set; }
        public string? PromoPlan { get; set; }
        public string? TotalAmount { get; set; }
        public string? MonthlyAmount { get; set; }
        public string? CreatedDate { get; set; }
        public List<bol_BS_Detail> BSDetailList { get; set; }
        public string? Duration { get; set; }
        public string? MRCTotal { get; set; }
    }
    public class bol_SPS_Dashboard
    {
        public int ActionParam { get; set; }
        public string LeadsConversionRatio { get; set; }
        public string City { get; set; }
        public int GroupID { get; set; }
        public string UserName { get; set; }
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
        public string FullName { get; set; }
        public string Role { get; set; }
        public string subscribercount { get; set; }
        public string SortBy { get; set; }
        public string saleswonsubscribercount { get; set; }

    }
    public class bol_SPS_Channel
    {
        public int ActionParam { get; set; }
        public string City { get; set; }
        public int GroupID { get; set; }
        public string UserName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int _5BBBusiness {get;set;}
        public int GoogleMyBusiness { get; set; }
        public int InPerson { get; set; }
        public int IncomingPhoneCall { get; set; }
        public int Instagram { get; set; }
        public int InterestForm { get; set; }
        public int Mailchimp { get; set; }
        public int OutdoorSales { get; set; }
        public int PageComments { get; set; }
        public int Telegram { get; set; }
        public int TikTok { get; set; }
        public int Viber { get; set; }
        public int Walkin { get; set; }
        public int WebsiteForms { get; set; }
    }

    public class bol_SPS_Detail
    {
        public int ActionParam { get; set; }
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? ServicePlan { get; set; }
        public string? PromoPlan { get; set; }
        public string? TotalAmount { get; set; }
        public string? MonthlyAmount { get; set; }
        public string? CreatedDate { get; set; }
        public List<bol_BS_Detail> BSDetailList { get; set; }
        public string? Duration { get; set; }
        public string? MRCTotal { get; set; }
    }

    public class bol_SPS_Group6Dashboard
    {
        public int ID { get; set; }

        public int ActionParam { get; set; }
        public string City { get; set; }
        public string GroupAndTeams { get; set; }
        public int GroupID { get; set; }
        public string UserName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string New { get; set; }
        public string FollowUp { get; set; }
        public string Qualify { get; set; }
        public string SalesWon { get; set; }
        public string SalesClosed { get; set; }
        public string TotalSales { get; set; }
        public string Wait { get; set; }
        public string Disqualify { get; set; }
        public string SalesLost { get; set; }
        public string ReceivedPayment { get; set; }
        public string Total { get; set; }

    }

}
