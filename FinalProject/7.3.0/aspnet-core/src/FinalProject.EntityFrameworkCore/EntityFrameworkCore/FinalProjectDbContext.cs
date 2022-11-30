using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FinalProject.Authorization.Roles;
using FinalProject.Authorization.Users;
using FinalProject.MultiTenancy;
using FinalProject.ShiftOffers;
using FinalProject.Availabilitys;

namespace FinalProject.EntityFrameworkCore
{
    public class FinalProjectDbContext : AbpZeroDbContext<Tenant, Role, User, FinalProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<ShiftOffer> ShiftOffers { get; set; }
        public virtual DbSet<Availability> Availabilities { get; set; }
        public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options)
            : base(options)
        {
        }
    }
}
