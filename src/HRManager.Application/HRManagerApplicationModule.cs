using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace HRManager
{
    [DependsOn(
        typeof(HRManagerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HRManagerApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HRManagerApplicationModule).GetAssembly());
        }
    }
}