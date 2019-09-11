using System;
using LoLCommon.Entities;

namespace LCC.Data.Entities
{
    public class Skin : ITrackableEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }
        public int ChampionId { get; set; }
        public virtual Champion Champion { get; set; }

        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? EditedDate { get; set; }
    }
}
