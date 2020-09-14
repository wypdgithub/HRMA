using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HRManager.Configuration;
using HRManager.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace HRManager.Web.Startup
{
    [DependsOn(
        typeof(HRManagerApplicationModule), 
        typeof(HRManagerEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class HRManagerWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public HRManagerWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(HRManagerConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<HRManagerNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(HRManagerApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HRManagerWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HRManagerWebModule).Assembly);
        }
    }
}