using Abp.Application.Services;
using FinalProject.MultiTenancy.Dto;

namespace FinalProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

