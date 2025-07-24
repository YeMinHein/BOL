using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    public class bol_API_Customer
    {

    }
    public class bol_API_CSInfo
    {
        public int ActionParam { get; set; }
        public string SearchText { get; set; }
        public string customerAccountNumber { get; set; }
        public string Name { get; set; }
        public string status { get; set; }
        public string PlanName { get; set; }
        public string expiryDate { get; set; }


        public string leadId { get; set; }
        public string cafNumber { get; set; }
        public string ioNumber { get; set; }
        public string title { get; set; }
        public string dateOfBirth { get; set; }
        public string gender { get; set; }
        public string creationDate { get; set; }
        public string emailAddress { get; set; }
        public string registeredMobileNumber { get; set; }
        public string billingArea { get; set; }
        public string customerCategory { get; set; }
        public string businessType { get; set; }
        public string condoSalesMasterName { get; set; }
        public string NRCNo { get; set; }


        public string PlanType { get; set; }
        public string price { get; set; }
        public string userId { get; set; }

        public List<bol_DepositDetails> DepositDetails { get; set; }

    }
    public class bol_API_CSBillList
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string customerAccountNumber { get; set; }
        public string billingAccountNumber { get; set; }
        public string AccountStatus { get; set; }
        public string CurrentPlan { get; set; }
        public string Name { get; set; }
        public string billNumber { get; set; }
        public string documentType { get; set; }
        public double amount { get; set; }
        public double unpaidAmount { get; set; }
        public string billDate { get; set; }
        public string dueDate { get; set; }
        public string billStatus { get; set; }
        public string disputedStatus { get; set; }
        public string billMonth { get; set; }
        public string billId { get; set; }
        public string currencyName { get; set; }
        public string SearchText { get; set; }
        public int PageIndex { get; set; }
    }

    public class bol_API_CSAccountHistory
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string customerAccountNumber { get; set; }
        public string serviceInstanceNumber { get; set; }
        public string planName { get; set; }
        public string planStatus { get; set; }
        public string dateTime { get; set; }
        public string staffId { get; set; }
        public string staffName { get; set; }
        public string functionality { get; set; }
        public string remark { get; set; }
        public string valueBefore { get; set; }
        public string valueAfter { get; set; }
        public string SearchText { get; set; }
        public int PageIndex { get; set; }
    }

    public class bol_API_SearchCustomerList
    {
        public int ActionParam { get; set; }
        
        public string UserName { get; set; }
        public string ActionID { get; set; }
        public string SearchText { get; set; }

        public int ID { get; set; }
        public string CUSTNAME { get; set; }
        public string PHONENO { get; set; }
        public string CUST_ACC { get; set; }
        public string CUSTCATEGORY { get; set; }
        public string SERVICETYPE { get; set; }
        public string ACCOUNTSTATUS { get; set; }

        public int PageIndex { get; set; }

        public string SearchTextServiceInstanceNo { get; set; }
    }


    public class bol_API_PrepaidHistory
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string customerAccountNumber { get; set; }

        public string effectiveDate { get; set; }
        public string packageName { get; set; }
        public string PMRVO_paymentDate { get; set; }
        public string currencyAlias { get; set; }
        public int PMRVO_totalTransactionAmount { get; set; }
        public string Type { get; set; }


        public string BillInvoiceNo { get; set; }
        public string merch_order_id { get; set; }
        public string ReceivableChannelAlias { get; set; }
        public string InternetRefNo { get; set; }
        public string CRNo { get; set; }
        public string Status { get; set; }

        public string PaymentSource { get; set; }
        public string PaymentOperator { get; set; }

        public int PageIndex { get; set; }

        public string CancelledDate { get; set; }
        public string CancelledBy { get; set; }
        public string CreatedBy { get; set; }
    }

    
}
