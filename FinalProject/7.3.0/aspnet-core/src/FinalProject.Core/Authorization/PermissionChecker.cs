using Abp.Authorization;
using FinalProject.Authorization.Roles;
using FinalProject.Authorization.Users;

namespace FinalProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
