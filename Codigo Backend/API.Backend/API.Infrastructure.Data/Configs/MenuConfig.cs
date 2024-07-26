using API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Data.Configs
{
    class MenuConfig : IEntityTypeConfiguration<MenuEntity>
    {
        public void Configure(EntityTypeBuilder<MenuEntity> builder)
        {
            builder.ToTable("Category_menu");
            builder.HasKey(c => c.id_category);
        }
    }
}
