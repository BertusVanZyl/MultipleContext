using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TwoContexts.Configuration.Dto;

namespace TwoContexts.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TwoContextsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
