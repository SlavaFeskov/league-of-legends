using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCC.Data.Entities.Mappings
{
    public class ChampionInfoEntityConfiguration : IEntityTypeConfiguration<ChampionInfo>
    {
        public void Configure(EntityTypeBuilder<ChampionInfo> builder)
        {
            builder.HasKey(ci => ci.Id);

            builder.HasOne(ci => ci.Champion)
                .WithOne(c => c.Info)
                .HasForeignKey<Champion>(c => c.InfoId);                          

            builder.Property(c => c.CreatedBy).IsRequired().HasMaxLength(256);
            builder.Property(c => c.EditedBy).HasMaxLength(256);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.EditedDate);
        }
    }
}
