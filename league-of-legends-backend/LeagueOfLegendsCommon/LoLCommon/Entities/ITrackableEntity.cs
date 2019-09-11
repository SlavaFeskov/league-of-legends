using System;

namespace LoLCommon.Entities
{
    public interface ITrackableEntity
    {
        string CreatedBy { get; set; }
        string EditedBy { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? EditedDate { get; set; }
    }
}
