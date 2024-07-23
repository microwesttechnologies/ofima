using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infraestructure.PersistenceEFCore.DataContext
{
    internal class SCRUMContextFactory : IDesignTimeDbContextFactory<SCRUMContext>
    {
        public SCRUMContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SCRUMContext>();

            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=SCRUMDB;");



            return new SCRUMContext(optionsBuilder.Options);
        }
    }
}
