using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LCC.Data
{
    public class LCCContextFactory : IDesignTimeDbContextFactory<LCCContext>
    {
        public LCCContext CreateDbContext(string[] args)
        {           
            var optionsBuilder = new DbContextOptionsBuilder<LCCContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LifeCycleChampionsDb;");                            

            return new LCCContext(optionsBuilder.Options);
        }
    }
}
