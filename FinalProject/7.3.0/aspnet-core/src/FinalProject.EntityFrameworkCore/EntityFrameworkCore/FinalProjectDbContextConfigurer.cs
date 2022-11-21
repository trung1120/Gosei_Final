using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.EntityFrameworkCore
{
    public static class FinalProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FinalProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FinalProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
