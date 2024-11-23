using Abp.Authorization;
using Abp.React.Authorization.Roles;
using Abp.React.Authorization.Users;

namespace Abp.React.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
