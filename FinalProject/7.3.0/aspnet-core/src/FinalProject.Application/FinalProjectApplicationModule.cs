using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FinalProject.Authorization;

namespace FinalProject
{
    [DependsOn(
        typeof(FinalProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FinalProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FinalProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FinalProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
