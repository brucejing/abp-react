using Abp.Application.Services;
using Abp.React.Sessions.Dto;
using System.Threading.Tasks;

namespace Abp.React.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
