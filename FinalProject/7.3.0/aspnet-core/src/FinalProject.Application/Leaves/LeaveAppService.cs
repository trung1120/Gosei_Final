using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Leaves
{
    public interface  LeaveAppService : IApplicationService  
    {
        Leave<ListResultDto> ;
    }
}
