using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCC.Data.Entities.Mappings
{
    public class ChampionStatsEntityConfiguration : IEntityTypeConfiguration<ChampionStats>
    {
        public void Configure(EntityTypeBuilder<ChampionStats> builder)
        {
            builder.HasKey(cs => cs.Id);

            builder.HasOne(cs => cs.Champion)
                .WithOne(c => c.Stats)
                .HasForeignKey<Champion>(c => c.StatsId);

            builder.Property(c => c.CreatedBy).IsRequired().HasMaxLength(256);
            builder.Property(c => c.EditedBy).HasMaxLength(256);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.EditedDate);
        }
    }
}
