using Abp.Application.Services;
using Abp.React.MultiTenancy.Dto;

namespace Abp.React.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

