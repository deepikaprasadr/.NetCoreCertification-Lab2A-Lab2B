using System.ComponentModel.DataAnnotations;
  
namespace Lab2RoutingNavigationConfigure.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Enter the Username")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Enter the Password")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="Password should be atleast 6 characters")]
        public string Password {  get; set; }
    }
}
