using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCC.Data.Entities.Mappings
{
    public class SkinEntityConfiguration : IEntityTypeConfiguration<Skin>
    {
        public void Configure(EntityTypeBuilder<Skin> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasOne(s => s.Champion)
                .WithMany(c => c.Skins)
                .HasForeignKey(s => s.ChampionId);

            builder.Property(c => c.CreatedBy).IsRequired().HasMaxLength(256);
            builder.Property(c => c.EditedBy).HasMaxLength(256);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.EditedDate);
        }
    }
}
