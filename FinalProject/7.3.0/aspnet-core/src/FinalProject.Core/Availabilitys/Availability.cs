using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Availabilitys
{
    public class Availability : Entity
    {
        public int UserId { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Date { get; set; }

        public Availability(int userId, string date)
        {
            UserId = userId;
            Date = date;

        }
    }
}
