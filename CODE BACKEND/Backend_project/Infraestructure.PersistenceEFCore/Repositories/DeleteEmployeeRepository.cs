using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Model.Entities;
using Domain.Services.Repositories;

namespace Infraestructure.PersistenceEFCore.Repositories
{
    internal class DeleteEmployeeRepository : IDeleteEmployeeRepository
    {
        private readonly SCRUMContext _context;

        public DeleteEmployeeRepository(SCRUMContext context)
        {
            _context = context;
        }

        public async ValueTask<int> Delete(int employeeId)
        {
            var employeeToDelete = await _context.Employees.FindAsync(employeeId);

            if (employeeToDelete == null)
            {
                return 0; 
            }

            _context.Employees.Remove(employeeToDelete);
            await _context.SaveChangesAsync();

            return employeeId; 
        }
    }
}
