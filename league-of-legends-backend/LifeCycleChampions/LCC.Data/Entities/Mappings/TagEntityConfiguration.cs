using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCC.Data.Entities.Mappings
{
    public class TagEntityConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasMany(t => t.Champions);                

            builder.Property(c => c.CreatedBy).IsRequired().HasMaxLength(256);
            builder.Property(c => c.EditedBy).HasMaxLength(256);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.EditedDate);
        }
    }
}
