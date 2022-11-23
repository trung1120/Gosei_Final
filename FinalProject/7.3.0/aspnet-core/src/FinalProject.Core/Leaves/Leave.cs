using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Authorization.Users;
namespace FinalProject.Leaves
{
    public class Leave : Entity 
    {
        public int UserId { get; set; }
        public string LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate{get ;set;}
        public string Status { get; set; }

        public User User  { get; set; }

        public
        public Leave(int userId,string leaveType,string status)
        {
            UserId = userId;
            LeaveType = leaveType;
            Status = status;
        }
    }
}
