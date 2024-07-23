using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.PersistenceEFCore.Repositories
{
    internal class UpdateEmployeeRepository : IUpdateEmployeeRepository
    {
        private readonly SCRUMContext Context;

        public UpdateEmployeeRepository(SCRUMContext context)
        {
            Context = context;
        }

        public void Update(Employee employee)
        {
           Context.Update(employee);
        }
    }
}
