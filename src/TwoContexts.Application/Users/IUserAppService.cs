using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TwoContexts.Roles.Dto;
using TwoContexts.Users.Dto;

namespace TwoContexts.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
