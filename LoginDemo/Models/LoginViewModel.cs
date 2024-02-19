using System.ComponentModel.DataAnnotations;

namespace LoginDemo.Models
{
    public class LoginViewModel
    {
       
        [Required]
        [Display(Name = "Email or Username")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
