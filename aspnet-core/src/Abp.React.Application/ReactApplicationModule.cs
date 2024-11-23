using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.React.Authorization;

namespace Abp.React;

[DependsOn(
    typeof(ReactCoreModule),
    typeof(AbpAutoMapperModule))]
public class ReactApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<ReactAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(ReactApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
