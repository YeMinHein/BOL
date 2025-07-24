using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.PAY
{
    public class bol_PAY_History
    {
        public int ActionParam { get; set; }
        public string SearchText { get; set; }
        public int SA_ID { get; set; }
        public int PageIndex { get; set; }
        public int PageTakeRows { get; set; }
        public int PageSkipsRows { get; set; }
        public string merch_order_id { get; set; }
        public string OrderCode { get; set; }
        public string PaymentType { get; set; }
        public string PromoName { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentOperator { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CreatedDateStr { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentAlias { get; set; }
        public string transaction_id { get; set; }
        public string PlanName { get; set; }
        public string RechargePackage { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentDateStr { get; set; }
        public string UpdatePaymentStatus { get; set; }
        public string LastStatusName { get; set; }
        public string customerAccountNo { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string NRC { get; set; }
        public double TotalAmount { get; set; }
        public string BillInvoiceNo { get; set; }
        public string PaymentDocumentNo { get; set; }
        public bool Is_Refund { get; set; }
        public string Refund_Remark { get; set; }
        public DateTime Refund_Date { get; set; }
        public string Refund_By { get; set; }
        public string OrderCancelledBy { get; set; }
        public string BillingArea { get; set; }
        public string UserName { get; set; }
        public DateTime OrderCancelledDate { get; set; }

        public string effectiveDate { get; set; }
        public string Status { get; set; }
        public string CancelledDate { get; set; }
        public string CancelledBy { get; set; }
        public string CreatedBy { get; set; }

        public string Region { get; set; }
        public string ReceivableChannelAlias { get; set; }

        public string SearchDateCategory { get; set; }

        //Evo
        public string custCode { get; set; }
        public string Account { get; set; }
        public string OfferCode { get; set; }
        public bool IsOnlyFailed { get; set; }
        public string StaffRemark { get; set; }
        public bool IsSyncBSS { get; set; }
        public string EODDate { get; set; }
    }
    public class bol_PAY_Failed_Detail
    {
        public int ID { get; set; }
        public string urls { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string PaymentDateStr { get; set; }
    }
    public class bol_PAY_Update_Remark
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string UserName { get; set; }

        [Required(ErrorMessage = "ServiceNo is required")]
        public string ServiceNo { get; set; }

        [Required(ErrorMessage = "PaymentMethod is required")]
        public string PaymentMethod { get; set; }

        [Required(ErrorMessage = "merch_order_id is required")]
        public string merch_order_id { get; set; }

        [Required(ErrorMessage = "Remark is required")]
        public string Remark { get; set; }
    }
 }
