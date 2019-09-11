using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LoLCommon.Repository
{
    public interface IUnitOfWork<TContext>
        where  TContext : DbContext
    {
        Task<int> CommitAsync();
    }
}
