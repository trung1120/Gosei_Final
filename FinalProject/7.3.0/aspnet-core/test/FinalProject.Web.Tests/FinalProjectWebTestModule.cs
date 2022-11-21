using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FinalProject.EntityFrameworkCore;
using FinalProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FinalProject.Web.Tests
{
    [DependsOn(
        typeof(FinalProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FinalProjectWebTestModule : AbpModule
    {
        public FinalProjectWebTestModule(FinalProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinalProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FinalProjectWebMvcModule).Assembly);
        }
    }
}