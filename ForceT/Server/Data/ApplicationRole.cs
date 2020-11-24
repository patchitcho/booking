using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ForceT.Server.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
