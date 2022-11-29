using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Availabilitys
{
    public interface IAvailabilityAppService : IApplicationService
    {
        Task<ListResultDto<AvailabilityListDto>> GetAll();
    }

    [AutoMapFrom(typeof(Availability))]
    public class AvailabilityListDto : EntityDto
    {
        public int UserId { get; set; }
        public string Date { get; set; }

        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
    }
}
