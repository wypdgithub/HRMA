using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace HRManager.EntityFrameworkCore
{
    [DependsOn(
        typeof(HRManagerCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class HRManagerEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HRManagerEntityFrameworkCoreModule).GetAssembly());
        }
    }
}