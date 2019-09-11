using System;
using LoLCommon.Entities;

namespace LCC.Data.Entities
{
    public class Passive : ITrackableEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public virtual Champion Champion { get; set; }

        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? EditedDate { get; set; }
    }
}
