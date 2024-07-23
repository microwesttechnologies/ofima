using Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.PersistenceEFCore.DataContext
{
    public class SCRUMContext : DbContext
    {
        public SCRUMContext(DbContextOptions<SCRUMContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
