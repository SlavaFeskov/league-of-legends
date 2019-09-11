using System;
using System.Collections.Generic;
using System.Linq;
using LoLCommon.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoLCommon.Repository
{
    public static class DbContextExtensions
    {
        internal static IEnumerable<ITrackableEntity> GetTrackableEntities(this DbContext dbContext, EntityState state)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            return dbContext.ChangeTracker.Entries()
                .Where(t => t.Entity is ITrackableEntity && t.State == state)
                .Select(t => t.Entity)
                .Cast<ITrackableEntity>();
        }
    }
}
