using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.API
{
    //public class bol_API_Merchant
    //{
    //    public int ActionParam { get; set; }
    //    public string MerchantCode { get; set; }
    //    public string MerchantName { get; set; }
    //    public string? ContactPerson { get; set; }
    //    public DateTime? CreatedDate { get; set; }
    //    public string? CreatedBy { get; set; }
    //}

    //public class bol_API_Merchant
    //{
    //    public string UserName { get; set; }
    //    public string Password { get; set; }
    //    public string MerchantCode { get; set; }
    //    public string MerchantName { get; set; }
    //    public string BranchName { get; set; }
    //    public string ContactPerson { get; set; }
    //    public string Mobile { get; set; }
    //    public string Address { get; set; }
    //}
    //public class bol_API_MerchantLoginLogResult
    //{
    //    public bol_API_MerchantLogin result { get; set; }
    //}

    public class bol_API_MerchantLoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string MerchantCode { get; set; }
        public string MerchantName { get; set; }
        public string BranchName { get; set; }
        public string ContactPerson { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }

    public class bol_API_MerchantLogin_History_Log
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class bol_API_MerchantLogin
    {
        public ResultMsg result { get; set; }
        public bol_API_MerchantLoginUser merchant { get; set; }
    }

    public class bol_API_GetMerchantInfo_History_Log
    {
        public int ActionParam { get; set; }
        public string MerchantCode { get; set; }
    }

    public class bol_API_GetMerchantInfoList
    {
        public ResultMsg result { get; set; }
        public List<bol_API_GetMerchantInfo> merchantList { get; set; }
    }

    public class bol_API_GetMerchantInfo
    {
        public string MerchantCode { get; set; }
        public string MerchantName { get; set; }
        public string ContactPerson { get; set; }
        public string BranchName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }

    public class bol_API_GetMerchantData
    {
        public string MerchantCode { get; set; }
        public string BranchName { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
    }

    public class bol_API_MerchantForgotPassword_History_Log
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }
    }

    public class bol_API_MerchantForgotPassword
    {
        public ResultMsg result { get; set; }
        public bol_API_GetMerchantData merchantData { get; set; }
    }
    public class bol_API_MerchantChangePassword_History_Log
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public class bol_API_MerchantChangePassword
    {
        public ResultMsg result { get; set; }
    }

    public class bol_API_GetCustomerInfo_History_Log
    {
        public int ActionParam { get; set; }
        public string CustomerAccountNo { get; set; }
    }
}
