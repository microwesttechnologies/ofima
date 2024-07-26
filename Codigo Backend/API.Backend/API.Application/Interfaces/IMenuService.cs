using API.Domain.Entity;

namespace API.Application.Interfaces
{
    public interface IMenuService
    {
        List<MenuEntity> GetAll();
    }
}


