using HRManager.Configuration;
using HRManager.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HRManager.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class HRManagerDbContextFactory : IDesignTimeDbContextFactory<HRManagerDbContext>
    {
        public HRManagerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HRManagerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(HRManagerConsts.ConnectionStringName)
            );

            return new HRManagerDbContext(builder.Options);
        }
    }
}