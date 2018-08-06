using System.Threading.Tasks;
using TwoContexts.Configuration.Dto;

namespace TwoContexts.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
