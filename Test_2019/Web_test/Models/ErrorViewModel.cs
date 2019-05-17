using System;
using  Web_test.Models;
namespace Web_test.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
       
    }
    
}