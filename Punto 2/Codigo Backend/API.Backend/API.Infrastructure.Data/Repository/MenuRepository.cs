using API.Domain.Entity;
using API.Domain.Interfaces.Repository;
using API.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace API.Infrastructure.Data.Repository
{
    public class MenuRepository : IRepositoryBase<MenuEntity, int>
    {
        private readonly MenuContext db;

        public MenuRepository(MenuContext db)
        {
            this.db = db;
        }

        public List<MenuEntity> GetAll()
        {
            return db.Category_menu
                .Include(m => m.Subcategory_menu)
                    .ThenInclude(s => s.Submenu_menu)
                        .ThenInclude(s => s.Finalmenu_menu)
                .ToList();
        }


    }
}
