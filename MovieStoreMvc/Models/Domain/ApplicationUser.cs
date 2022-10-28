using Microsoft.AspNetCore.Identity;

namespace MovieStoreMvc.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name{ get; set; }
    }
}
