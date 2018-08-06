using Abp.Authorization;
using TwoContexts.Authorization.Roles;
using TwoContexts.Authorization.Users;

namespace TwoContexts.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
