using System.Threading.Tasks;
using Abp.Application.Services;
using FinalProject.Authorization.Accounts.Dto;

namespace FinalProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
