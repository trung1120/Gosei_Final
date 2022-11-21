using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Controllers
{
    public abstract class FinalProjectControllerBase: AbpController
    {
        protected FinalProjectControllerBase()
        {
            LocalizationSourceName = FinalProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
