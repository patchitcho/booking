using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Proxima.Server.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
