using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FinalProject.Authorization.Roles;
using FinalProject.Authorization.Users;
using FinalProject.MultiTenancy;

namespace FinalProject.EntityFrameworkCore
{
    public class FinalProjectDbContext : AbpZeroDbContext<Tenant, Role, User, FinalProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options)
            : base(options)
        {
        }
    }
}
