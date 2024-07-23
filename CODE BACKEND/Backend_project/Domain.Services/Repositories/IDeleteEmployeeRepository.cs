namespace Domain.Services.Repositories
{
    public interface IDeleteEmployeeRepository
    {
        ValueTask<int> Delete(int employeeId);

    }
}
