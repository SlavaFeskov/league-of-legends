using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LoLCommon.Repository
{
    public interface IRepository<TEntity, TContext> : IDisposable
        where TEntity : class
        where TContext : DbContext
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        Task<TEntity> GetByIdAsync(object id);
        IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetMany();
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
    }
}