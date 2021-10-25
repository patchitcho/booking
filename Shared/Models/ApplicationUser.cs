using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Proxima.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
