using Abp.Application.Services;
using Abp.React.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace Abp.React.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
