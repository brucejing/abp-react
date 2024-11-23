using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.React.Configuration;
using Abp.React.EntityFrameworkCore;
using Abp.React.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace Abp.React.Migrator;

[DependsOn(typeof(ReactEntityFrameworkModule))]
public class ReactMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public ReactMigratorModule(ReactEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(ReactMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            ReactConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(ReactMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
