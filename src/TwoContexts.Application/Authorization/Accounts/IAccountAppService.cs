using System.Threading.Tasks;
using Abp.Application.Services;
using TwoContexts.Authorization.Accounts.Dto;

namespace TwoContexts.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
