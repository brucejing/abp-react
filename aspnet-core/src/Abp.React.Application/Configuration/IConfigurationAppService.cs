using Abp.React.Configuration.Dto;
using System.Threading.Tasks;

namespace Abp.React.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
