using Abp.Application.Services;

namespace HRManager
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class HRManagerAppServiceBase : ApplicationService
    {
        protected HRManagerAppServiceBase()
        {
            LocalizationSourceName = HRManagerConsts.LocalizationSourceName;
        }
    }
}