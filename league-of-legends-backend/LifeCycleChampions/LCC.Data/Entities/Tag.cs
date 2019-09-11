using System;
using System.Collections.Generic;
using LoLCommon.Entities;

namespace LCC.Data.Entities
{
    public class Tag : ITrackableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Champion> Champions { get; set; }

        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? EditedDate { get; set; }
    }
}
