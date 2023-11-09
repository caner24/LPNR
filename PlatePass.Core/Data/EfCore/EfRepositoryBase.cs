using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Core.Data.EfCore
{
    public class EfRepositoryBase<TContext, TEntity> : IEntityRepositoryBase<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        private readonly TContext _dbContext;
        public EfRepositoryBase()
        {
            _dbContext = new TContext();
        }
        public async Task<TEntity> AddEntityAsync(TEntity entity)
        {

            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;

        }
        public async Task<int> DeleteEntityByIdentityAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }
        public IQueryable<TEntity> GetAllEntityAsync(Expression<Func<TEntity, bool>> filter = null)
        {

            return filter == null ? _dbContext.Set<TEntity>().AsNoTracking() : _dbContext.Set<TEntity>().Where(filter).AsNoTracking();
        }

        public IQueryable<TEntity> GetEntityByIdentityAsync(Expression<Func<TEntity, bool>> filter)
        {
            return _dbContext.Set<TEntity>().Where(filter).AsNoTracking();
        }

        public async Task<TEntity> UpdateEntityAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
