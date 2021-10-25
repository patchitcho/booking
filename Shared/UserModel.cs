using Proxima.Shared.Models;

namespace Proxima.Shared
{
    public class UserModel
    {
        public string User { get; set; }
        public ApplicationRole Roles { get; set; }

        //public bool IsAuthenticated { get; set; }
    }
}
