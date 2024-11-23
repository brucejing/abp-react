using Abp.Authorization;
using Abp.Runtime.Session;
using Abp.React.Configuration.Dto;
using System.Threading.Tasks;

namespace Abp.React.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : ReactAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
