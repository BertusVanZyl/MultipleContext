using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TwoContexts.Controllers
{
    public abstract class TwoContextsControllerBase: AbpController
    {
        protected TwoContextsControllerBase()
        {
            LocalizationSourceName = TwoContextsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
