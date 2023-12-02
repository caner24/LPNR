using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Business.Abstract
{
    public interface IPlateService
    {
        Task<List<Plate>> GetAllEntityAsync(Expression<Func<Plate, bool>> filter = null);

        Task<Plate> GetEntityByIdentityAsync(Expression<Func<Plate, bool>> filter);

        Task<int> DeleteEntityByIdentityAsync(string id);

        Task<Plate> UpdateEntityAsync(Plate entity);

        Task<Plate> AddEntityAsync(Plate entity);
    }
}
