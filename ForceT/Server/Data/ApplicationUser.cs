using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ForceT.Server.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
