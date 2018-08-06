using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TwoContexts.MultiTenancy.Dto;

namespace TwoContexts.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
