using System;
using System.Threading.Tasks;
using LoLCommon.Users;
using LoLCommon.Wrappers;
using Microsoft.EntityFrameworkCore;

namespace LoLCommon.Repository
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>
        where TContext : DbContext
    {
        private readonly IUserService _userService;
        private readonly IDateTimeWrapper _dateTimeWrapper;

        protected readonly TContext DbContext;

        public UnitOfWork(IUserService userService,
            IDateTimeWrapper dateTimeWrapper,
            TContext dbContext)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _dateTimeWrapper = dateTimeWrapper ?? throw new ArgumentNullException(nameof(dateTimeWrapper));

            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<int> CommitAsync()
        {
            FillAuditFields();
            return await DbContext.SaveChangesAsync();
        }

        protected virtual void FillAuditFields()
        {
            var user = _userService.UserName;
            var utcNow = _dateTimeWrapper.UtcNow;

            foreach (var entity in DbContext.GetTrackableEntities(EntityState.Added))
            {
                entity.CreatedBy = user;
                entity.CreatedDate = utcNow;
            }

            foreach (var entity in DbContext.GetTrackableEntities(EntityState.Modified))
            {
                entity.EditedBy = user;
                entity.EditedDate = utcNow;
            }
        }
    }
}
