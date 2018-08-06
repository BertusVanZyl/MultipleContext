using System.Threading.Tasks;
using Abp.Application.Services;
using TwoContexts.Sessions.Dto;

namespace TwoContexts.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
