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
        public async Task<List<TEntity>> GetAllEntityAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? await _dbContext.Set<TEntity>().ToListAsync() : await _dbContext.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<TEntity> GetEntityByIdentityAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task<TEntity> UpdateEntityAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
