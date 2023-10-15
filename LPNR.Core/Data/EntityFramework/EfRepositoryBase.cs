using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LPNR.Core.Data.EntityFramework
{
    public class EfRepositoryBase<TContext, TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        private readonly TContext _dbContext;
        public async Task<TEntity> AddEntityAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> DeleteEntityAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAllEntityAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _dbContext.Set<TEntity>() : _dbContext.Set<TEntity>().Where(filter);
        }

        public IQueryable<TEntity> GetEntityByIdentity(Expression<Func<TEntity, bool>> filter)
        {
            return _dbContext.Set<TEntity>().Where(filter);
        }

        public async Task<TEntity> UpdateEntityAsync(TEntity entity)
        {
            var updatedEntity = _dbContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
