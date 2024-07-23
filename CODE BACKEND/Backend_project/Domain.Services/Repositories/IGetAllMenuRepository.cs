namespace Domain.Services.Repositories
{
    public interface IGetAllMenuRepository
    {
        ValueTask<IEnumerable<Menu>> GetAll();
    }
}
