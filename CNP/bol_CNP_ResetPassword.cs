using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CNP
{
    public class bol_CNP_ResetPassword
    {
        public int ActionParam { get; set; }
        public string? CustomerAccNo { get; set; }
        public string? CustomerName { get; set; }
        public string? MobileNo { get; set; }
        public string Plan { get; set; }
        public string Password { get; set; }
        public string? SearchText { get; set; }
    }
    public class bol_CNP_ResponseLog
    {
        public string Id { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public string UserName { get; set; }
        public string URL { get; set; }
        public string Code { get; set; }
        public string RequestBody { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
