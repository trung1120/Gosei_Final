using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FinalProject.Configuration.Dto;

namespace FinalProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FinalProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
