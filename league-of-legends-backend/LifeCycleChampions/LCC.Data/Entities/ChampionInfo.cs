using System;
using LoLCommon.Entities;

namespace LCC.Data.Entities
{
    public class ChampionInfo : ITrackableEntity
    {
        public int Id { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Difficulty { get; set; }
        public int Magic { get; set; }
        public virtual Champion Champion { get; set; }

        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? EditedDate { get; set; }
    }
}
