using Abp.AspNetCore.Mvc.Controllers;

namespace HRManager.Web.Controllers
{
    public abstract class HRManagerControllerBase: AbpController
    {
        protected HRManagerControllerBase()
        {
            LocalizationSourceName = HRManagerConsts.LocalizationSourceName;
        }
    }
}