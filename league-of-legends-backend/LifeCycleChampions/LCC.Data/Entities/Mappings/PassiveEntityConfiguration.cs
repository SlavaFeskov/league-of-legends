using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCC.Data.Entities.Mappings
{
    public class PassiveEntityConfiguration : IEntityTypeConfiguration<Passive>
    {
        public void Configure(EntityTypeBuilder<Passive> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Champion)
                .WithOne(c => c.Passive)
                .HasForeignKey<Champion>(c => c.PassiveId);

            builder.Property(c => c.CreatedBy).IsRequired().HasMaxLength(256);
            builder.Property(c => c.EditedBy).HasMaxLength(256);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.EditedDate);
        }
    }
}
