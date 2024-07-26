

namespace API.Domain.Interfaces.Repository
{
    public interface IGetMenu<TMenu, TMenuId>
    {
        List<TMenu> GetAll();
    }
}
