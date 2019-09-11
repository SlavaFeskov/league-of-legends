using LCC.Data.Entities;
using LCC.Data.Entities.Mappings;
using Microsoft.EntityFrameworkCore;

namespace LCC.Data
{
    public class LCCContext : DbContext
    {
        public DbSet<Champion> Champions { get; set; }
        public DbSet<ChampionInfo> ChampionInfos { get; set; }
        public DbSet<ChampionStats> ChampionStats { get; set; }
        public DbSet<Passive> Passives { get; set; }
        public DbSet<Skin> Skins { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ChampionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ChampionInfoEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ChampionStatsEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PassiveEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SkinEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TagEntityConfiguration());
        }
    }
}
