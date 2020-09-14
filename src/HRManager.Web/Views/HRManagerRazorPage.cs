using Abp.AspNetCore.Mvc.Views;

namespace HRManager.Web.Views
{
    public abstract class HRManagerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected HRManagerRazorPage()
        {
            LocalizationSourceName = HRManagerConsts.LocalizationSourceName;
        }
    }
}
