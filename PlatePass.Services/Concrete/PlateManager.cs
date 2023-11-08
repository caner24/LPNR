using PlatePass.Business.Abstract;
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
    public class PlateManager : IPlateService
    {
        private readonly IPlateDal _plateDal;
        public PlateManager(IPlateDal plateDal)
        {
            _plateDal = plateDal;
        }
        public async Task<Plate> AddEntityAsync(Plate entity)
        {
            await _plateDal.AddEntityAsync(entity);
            return entity;
        }

        public async Task<int> DeleteEntityByIdentityAsync(int id)
        {
            var user = await GetEntityByIdentityAsync(x => x.Id == id);
            if (user == null)
                throw new Exception("Aradığınız kullanici bulunamadi");

            return await _plateDal.DeleteEntityByIdentityAsync(user);

        }

        public async Task<List<Plate>> GetAllEntityAsync(Expression<Func<Plate, bool>> filter = null)
        {
            return filter == null ? await _plateDal.GetAllEntityAsync() : await _plateDal.GetAllEntityAsync(filter);
        }

        public async Task<Plate> GetEntityByIdentityAsync(Expression<Func<Plate, bool>> filter)
        {
            return await _plateDal.GetEntityByIdentityAsync(filter);

        }

        public async Task<Plate> UpdateEntityAsync(Plate entity)
        {
            await _plateDal.UpdateEntityAsync(entity);
            return entity;
        }
    }
}
