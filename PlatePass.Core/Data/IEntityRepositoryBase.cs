using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Core.Data
{
    public interface IEntityRepositoryBase<TEntity> where TEntity : class, IEntity, new()
    {
        IQueryable<TEntity> GetAllEntityAsync(Expression<Func<TEntity, bool>> filter = null);

        IQueryable<TEntity> GetEntityByIdentityAsync(Expression<Func<TEntity, bool>> filter);

        Task<int> DeleteEntityByIdentityAsync(TEntity entity);

        Task<TEntity> UpdateEntityAsync(TEntity entity);

        Task<TEntity> AddEntityAsync(TEntity entity);

    }
}
