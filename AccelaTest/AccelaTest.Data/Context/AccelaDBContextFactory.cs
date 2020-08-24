using AccelaTest.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AccelaTest.Data.Context
{
    public class AccelaDBContextFactory : IDesignTimeDbContextFactory<AccelaDBContext>
    {
        public AccelaDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AccelaDBContext>();
            optionsBuilder.UseSqlServer(ConnConfig.GetConnection());

            return new AccelaDBContext(optionsBuilder.Options);
        }
    }
}