namespace API.Domain.Interfaces
{
    public interface GetAllMenu<TMenu, TMenuId>
    {
        List<TMenu> GetAllMenu();

    }
}
