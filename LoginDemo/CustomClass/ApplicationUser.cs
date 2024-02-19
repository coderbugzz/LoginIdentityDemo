using Microsoft.AspNetCore.Identity;

namespace LoginDemo.CustomClass
{
    public class ApplicationUser : IdentityUser
    {
        public string? Contact { get; set; }
    }
}
