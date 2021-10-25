using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Proxima.Shared.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
