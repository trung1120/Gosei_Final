using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Leaves
{
    public class LeaveProfile : Profile
    {
        public LeaveProfile()
        {
            CreateMap<LeaveListDto, Leave>();
        }
    }
}
