using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ForceT.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
