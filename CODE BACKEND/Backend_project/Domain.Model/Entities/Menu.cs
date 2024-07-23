using System;
using System.Collections.Generic;

namespace Domain.Model.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SubcategoryMenu> Subcategories { get; set; } = new List<SubcategoryMenu>();
    }

    public class SubcategoryMenu
    {
        public int IdSubcategory { get; set; }
        public string NameSubcategory { get; set; }
        public int IdCategory { get; set; }
        public ICollection<SubmenuMenu> Submenus { get; set; } = new List<SubmenuMenu>();
    }

    public class SubmenuMenu
    {
        public int IdSubmenu { get; set; }
        public string NameSubmenu { get; set; }
        public int IdSubcategory { get; set; }
        public SubcategoryMenu Subcategory { get; set; }
        public ICollection<FinalMenu> FinalMenus { get; set; } = new List<FinalMenu>();
    }

    public class FinalMenu
    {
        public int IdFinalmenu { get; set; }
        public string NameFinalmenu { get; set; }
        public int IdSubmenu { get; set; }
        public SubmenuMenu Submenu { get; set; }
    }
}
