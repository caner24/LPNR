using Microsoft.EntityFrameworkCore;
using PlatePass.Business.Abstract;
using PlatePass.Core.Data;
using PlatePass.DataAcess.Abstract;
using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Business.Concrete
{
    public class PlateDetailManager : IPlateDetailService
    {
        private readonly IPlateDetailDal _plateDetailDal;
        public PlateDetailManager(IPlateDetailDal plateDal)
        {
            _plateDetailDal = plateDal;
        }
        public async Task<PlateDetails> AddEntityAsync(PlateDetails entity)
        {
            await _plateDetailDal.AddEntityAsync(entity);
            return entity;
        }

        public Task<int> DeleteEntityByIdentityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PlateDetails>> GetAllEntityAsync(Expression<Func<PlateDetails, bool>> filter = null)
        {
            return filter == null ? await _plateDetailDal.GetAllEntityAsync().Take(10).Include(x => x.Plate).ToListAsync() : await _plateDetailDal.GetAllEntityAsync(filter).Take(10).Include(x => x.Plate).ToListAsync();
        }

        public async Task<PlateDetails> GetEntityByIdentityAsync(Expression<Func<PlateDetails, bool>> filter)
        {
            return await _plateDetailDal.GetEntityByIdentityAsync(filter).FirstOrDefaultAsync();
        }

        public Task<PlateDetails> UpdateEntityAsync(PlateDetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
