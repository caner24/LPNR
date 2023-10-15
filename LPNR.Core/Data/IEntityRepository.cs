using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LPNR.Core.Data
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> AddEntityAsync(T entity);
        IQueryable<T> GetAllEntityAsync(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetEntityByIdentity(Expression<Func<T, bool>> filter);
        Task<T> UpdateEntityAsync(T entity);
        Task<int> DeleteEntityAsync(T entity);
    }
}
