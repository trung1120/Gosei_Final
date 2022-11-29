using FinalProject.Availabilitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EntityFrameworkCore.Seed.AvailabilityFoder
{
    public class DefaultAvailabilityBuilder
    {
        private readonly FinalProjectDbContext _context;
        private readonly int _Id;
        public DefaultAvailabilityBuilder(FinalProjectDbContext context, int id)
        {
            _context = context;
            _Id = id;
        }
        public void Create()
        {
            var availabilitys = new List<Availability>
            {
                new Availability(_Id,"28-11-2022")
            };
            foreach (var Availability in availabilitys)
            {
                var existringAvailability = _context.Availabilities.IgnoreQueryFilters().FirstOrDefault(a => a.Id == Availability.Id);

                if (existringAvailability == null)
                {
                    _context.Availabilities.Add(Availability);
                }
            }
            _context.SaveChanges();

        }

    }
}
