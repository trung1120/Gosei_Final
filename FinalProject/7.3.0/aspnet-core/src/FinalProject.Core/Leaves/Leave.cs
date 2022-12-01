using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Leaves
{
    public class Leave : Entity
    {
        public int UserId { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string ToDate { get; set; }
        public string Status { get; set; }

        public Leave(int userId, string toDate, string status)
        {
            UserId = userId;
            ToDate = toDate;
            Status = status;
        }
    }
}
