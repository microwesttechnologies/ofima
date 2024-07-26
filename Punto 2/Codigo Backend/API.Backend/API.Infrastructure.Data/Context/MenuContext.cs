using API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Data.Context
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options)
            : base(options)
        {
        }

        public DbSet<MenuEntity> Category_menu { get; set; }
        public DbSet<SubcategoryEntity> Subcategory_menu { get; set; }
        public DbSet<SubmenuEntity> Submenu_menu { get; set; }
        public DbSet<FinalmenuEntity> Finalmenu_menu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuEntity>()
                .HasKey(m => m.id_category);

            modelBuilder.Entity<SubcategoryEntity>()
                .HasKey(s => s.id_subcategory);

            modelBuilder.Entity<SubmenuEntity>()
                .HasKey(s => s.id_submenu);

            modelBuilder.Entity<FinalmenuEntity>()
                .HasKey(f => f.id_finalmenu);

            modelBuilder.Entity<SubcategoryEntity>()
                .HasOne(s => s.Category_menu)
                .WithMany(m => m.Subcategory_menu)
                .HasForeignKey(s => s.id_category);

            modelBuilder.Entity<SubmenuEntity>()
                .HasOne(s => s.Subcategory_menu)
                .WithMany(s => s.Submenu_menu)
                .HasForeignKey(s => s.id_subcategory);

            modelBuilder.Entity<FinalmenuEntity>()
                .HasOne(f => f.Submenu_menu)
                .WithMany(s => s.Finalmenu_menu)
                .HasForeignKey(f => f.id_submenu);
        }
    }
}
