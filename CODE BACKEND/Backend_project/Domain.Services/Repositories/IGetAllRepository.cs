namespace Domain.Services.Repositories
{
    public interface IGetAllRepository
    {
        ValueTask<IEnumerable<Employee>> GetAll();
    }
}
