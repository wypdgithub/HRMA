using Microsoft.EntityFrameworkCore;

namespace HRManager.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<HRManagerDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for HRManagerDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
