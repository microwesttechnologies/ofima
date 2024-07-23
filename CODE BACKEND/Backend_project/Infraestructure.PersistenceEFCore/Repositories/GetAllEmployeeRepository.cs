using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.PersistenceEFCore.Repositories
{
    internal class GetAllEmployeeRepository : IGetAllRepository
    {
        readonly SCRUMContext Context;

        public GetAllEmployeeRepository(SCRUMContext context)
        {
            Context = context;
        }

        public async ValueTask<IEnumerable<Employee>> GetAll()
        {
           return await Context.Employees.ToListAsync();
        }
    }
}
