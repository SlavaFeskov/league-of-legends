using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LCC.Data.Entities.Mappings
{
    public class ChampionEntityConfiguration : IEntityTypeConfiguration<Champion>
    {
        public void Configure(EntityTypeBuilder<Champion> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Lore);
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Partype);
            builder.Property(c => c.Title);

            builder.HasOne(c => c.Stats)
                .WithOne(s => s.Champion)
                .HasForeignKey<Champion>(c => c.StatsId);
            builder.HasOne(c => c.Info)
                .WithOne(s => s.Champion)
                .HasForeignKey<Champion>(c => c.InfoId);
            builder.HasOne(c => c.Passive)
                .WithOne(s => s.Champion)
                .HasForeignKey<Champion>(c => c.PassiveId);

            builder.HasMany(c => c.Skins)
                .WithOne(s => s.Champion)
                .HasForeignKey(s => s.ChampionId);

            builder.HasMany(c => c.Tags);

            builder.Property(c => c.CreatedBy).IsRequired().HasMaxLength(256);
            builder.Property(c => c.EditedBy).HasMaxLength(256);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.EditedDate);
        }
    }
}
