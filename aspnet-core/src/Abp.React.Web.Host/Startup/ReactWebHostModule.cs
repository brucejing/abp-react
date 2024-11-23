using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.React.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Abp.React.Web.Host.Startup
{
    [DependsOn(
       typeof(ReactWebCoreModule))]
    public class ReactWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReactWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReactWebHostModule).GetAssembly());
        }
    }
}
