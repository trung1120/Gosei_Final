using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using FinalProject.MultiTenancy;

namespace FinalProject.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
