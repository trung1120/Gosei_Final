using System.Threading.Tasks;
using FinalProject.Configuration.Dto;

namespace FinalProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
