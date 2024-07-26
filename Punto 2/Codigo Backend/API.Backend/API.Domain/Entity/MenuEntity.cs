using System.ComponentModel.DataAnnotations;

namespace API.Domain.Entity
{


    public class MenuEntity
    {
        [Key]
        public int id_category { get; set; }
        public string name_category { get; set; }
        public ICollection<SubcategoryEntity> Subcategory_menu { get; set; }
    }

    public class SubcategoryEntity
    {
        [Key]
        public int id_subcategory { get; set; }
        public string name_subcategory { get; set; }
        public int id_category { get; set; }
        public MenuEntity Category_menu { get; set; }
        public ICollection<SubmenuEntity> Submenu_menu { get; set; }
    }

    public class SubmenuEntity
    {
        [Key]
        public int id_submenu { get; set; }
        public string name_submenu { get; set; }
        public int id_subcategory { get; set; }
        public SubcategoryEntity Subcategory_menu { get; set; }
        public ICollection<FinalmenuEntity> Finalmenu_menu { get; set; }
    }

    public class FinalmenuEntity
    {
        [Key]
        public int id_finalmenu { get; set; }
        public string name_finalmenu { get; set; }
        public int id_submenu { get; set; }
        public SubmenuEntity Submenu_menu { get; set; }
    }
}
