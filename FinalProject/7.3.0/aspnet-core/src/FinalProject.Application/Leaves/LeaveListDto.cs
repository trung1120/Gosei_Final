using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Leaves
{
    [AutoMapFrom(typeof(Leave))]
    public class LeaveListDto : EntityDto
    {
        public int UserId { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string ToDate { get; set; }
        public string Status { get; set; }
    }
}
