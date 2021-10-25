using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Proxima.Server.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
