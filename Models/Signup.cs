using Lab2RoutingNavigationConfigure.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Lab2RoutingNavigationConfigure.Models
{
    public class Signup
    {
        [Required(ErrorMessage ="Enter the Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter the Email")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Enter the Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Reenter the Password")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^[6789]\d{9}$",ErrorMessage ="Invalid Contact Number")]    
        public int? Phone { get; set; }

        //  [Required(ErrorMessage ="Accept Terms and Conditions")]
        [ValidateCheckBox(ErrorMessage ="Accept Terms and Conditions")]
        public bool Terms { get; set; }
    }
}
