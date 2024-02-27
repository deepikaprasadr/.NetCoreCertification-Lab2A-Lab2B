using Lab2RoutingNavigationConfigure.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2RoutingNavigationConfigure.Models
{
    //learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/validation?view=aspnetcore-8.0&tabs=visual-studio
    public class RegisterUserModel
    {

        [Required(ErrorMessage ="Enter the Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter the Email")]
        [EmailAddress(ErrorMessage ="Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Enter a Password")]
        //[RegularExpression("[A-Za-z0-9^@#$%]")]//[StringLength(60,MinimumLength =8)]
        //[RegularExpression((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[#$@!%&*?]).{8,})]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*[0-9])(?=.*[!@#$%^&*-]).{8,}$", ErrorMessage = "Passwordrequired(1Uppercase,1Number,1SpecialChar and 1LowercaseChar)")]                
        public string Password { get; set; }

        [Required(ErrorMessage ="Confirm the Password")]
        [Compare("Password", ErrorMessage ="Confirm password is not matching")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Enter the Contact")]
        [RegularExpression("^[6789]\\d{9}$",ErrorMessage ="Enter correct number")]
        public string Contact { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage ="Gender is required")]
        public string Gender { get; set; }
        //public bool Gender { get; set; }
        // [Required(ErrorMessage ="Accept the Terms")]
       [ValidateCheckBox(ErrorMessage = "Accept the Terms")]
        public bool AcceptTerms { get; set; }

    }
}
