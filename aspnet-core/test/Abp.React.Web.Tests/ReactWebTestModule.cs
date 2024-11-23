using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.React.EntityFrameworkCore;
using Abp.React.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Abp.React.Web.Tests;

[DependsOn(
    typeof(ReactWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class ReactWebTestModule : AbpModule
{
    public ReactWebTestModule(ReactEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(ReactWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(ReactWebMvcModule).Assembly);
    }
}