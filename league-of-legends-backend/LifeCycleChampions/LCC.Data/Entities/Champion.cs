using System;
using System.Collections.Generic;
using LoLCommon.Entities;

namespace LCC.Data.Entities
{
    public class Champion : ITrackableEntity
    {
        public int Id { get; set; }
        public string Lore { get; set; }
        public string Name { get; set; }
        public string Partype { get; set; }
        public string Title { get; set; }
        public int StatsId { get; set; }
        public virtual ChampionStats Stats { get; set; }
        public int PassiveId { get; set; }
        public virtual Passive Passive { get; set; }
        public int InfoId { get; set; }
        public virtual ChampionInfo Info { get; set; }        
        public List<Tag> Tags { get; set; }
        public List<Skin> Skins { get; set; }

        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? EditedDate { get; set; }
    }
}
