using API.Application.Interfaces;
using API.Domain.Entity;
using API.Domain.Interfaces.Repository;

namespace API.Application.Services
{
    public class MenuService : IMenuService
    {
        private readonly IRepositoryBase<MenuEntity, int> repoMenu;

        public MenuService(IRepositoryBase<MenuEntity, int> repoMenu)
        {
            this.repoMenu = repoMenu;
        }

        public List<MenuEntity> GetAll()
        {
            return repoMenu.GetAll();
        }
    }
}
