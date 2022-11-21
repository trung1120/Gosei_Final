using System.Threading.Tasks;
using Abp.Application.Services;
using FinalProject.Sessions.Dto;

namespace FinalProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
