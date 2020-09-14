using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HRManager.Web.Startup;
namespace HRManager.Web.Tests
{
    [DependsOn(
        typeof(HRManagerWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class HRManagerWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HRManagerWebTestModule).GetAssembly());
        }
    }
}