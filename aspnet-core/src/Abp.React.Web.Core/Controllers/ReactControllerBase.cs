using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Abp.React.Controllers
{
    public abstract class ReactControllerBase : AbpController
    {
        protected ReactControllerBase()
        {
            LocalizationSourceName = ReactConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
