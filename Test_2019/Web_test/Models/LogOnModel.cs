using System;
using System.ComponentModel.DataAnnotations;
namespace Web_test.Models
{
    public class LogOnModel
    {
        
        [Required]
        public string  UserName { get; set; }      

        [Required]
        [DataType(dataType:DataType.Password)]
        public string Password { get; set; }
    }
}
