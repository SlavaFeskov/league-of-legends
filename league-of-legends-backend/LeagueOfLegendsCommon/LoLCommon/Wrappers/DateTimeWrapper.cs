using System;

namespace LoLCommon.Wrappers
{
    public class DateTimeWrapper : IDateTimeWrapper
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
