namespace Domain.Services.Repositories
{
    public interface IGetEmployeeByIdRepository
    {
        ValueTask<Employee> GetEmployeeById(int employeeId);
    }
}
