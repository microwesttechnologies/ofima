
namespace Infraestructure.PersistenceEFCore.Repositories
{
    internal class GetEmployeeByIdRepository : IGetEmployeeByIdRepository
    {
        private readonly SCRUMContext Context;

        public GetEmployeeByIdRepository(SCRUMContext context)
        {
            Context = context;
        }

        public async ValueTask<Employee> GetEmployeeById(int employeeId)
        {
            var employee = await Context.Employees.Where(employee => employee.Id == employeeId).FirstOrDefaultAsync();

            return employee;
        }
    }
}
