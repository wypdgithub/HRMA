using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRManager.EntityFrameworkCore
{
    public class HRManagerDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public HRManagerDbContext(DbContextOptions<HRManagerDbContext> options) 
            : base(options)
        {

        }
    }
}
