using Abp.Modules;
using Abp.Reflection.Extensions;
using HRManager.Localization;

namespace HRManager
{
    public class HRManagerCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            HRManagerLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HRManagerCoreModule).GetAssembly());
        }
    }
}