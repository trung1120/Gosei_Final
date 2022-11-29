using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Availabilitys
{
    public class AvailabilityAppService : FinalProjectAppServiceBase, IAvailabilityAppService
    {
        private readonly IRepository<Availability> _availabilityRepository;

        public AvailabilityAppService(IRepository<Availability> availabilityRepository)
        {
            _availabilityRepository = availabilityRepository;
        }
        public async Task<ListResultDto<AvailabilityListDto>> GetAll()
        {
            var availability = await _availabilityRepository
                .GetAll()
                .ToListAsync();

            var dtos = ObjectMapper.Map<List<AvailabilityListDto>>(availability);
            return new ListResultDto<AvailabilityListDto>(dtos);
        }
    }
}
