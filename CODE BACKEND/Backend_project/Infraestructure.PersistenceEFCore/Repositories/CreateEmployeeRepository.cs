

using Domain.Services.Repositories;


namespace Infraestructure.PersistenceEFCore.Repositories
{
    internal class CreateEmployeeRepository : ICreateEmployeeRepository
    {
        readonly SCRUMContext Context;

        public CreateEmployeeRepository(SCRUMContext context)
        {
            Context = context;
        }

        public void Create(Employee employee)
        {
            Context.Add(employee);
        }
    }
}
