using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValidationLibrary
{
    
    public class Registration
    {
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Password is must")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="confirm Password is Must")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Enter Age Please")]
        [Range(typeof(int),"18","50",ErrorMessage ="Age to be between 18 and 50 only")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Email is compulsory")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage ="Pls Enter Email in the correct format")]
        public string Email { get; set; }
    }
}
