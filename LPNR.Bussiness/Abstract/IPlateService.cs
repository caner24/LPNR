using LPNR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LPNR.Bussiness.Abstract
{
    public interface IPlateService
    {
        Task<Plate> GetPlateByIdentityAsync(Expression<Func<Plate, bool>> filter);
        Task<List<Plate>> GetAllPlateAsync(Expression<Func<Plate, bool>> filter = null);

        Task<Plate> AddEntityAsync(Plate entity);
        Task<int> DeletePlateAsync(Plate plate);

        Task<Plate> UpdatePlateAsync(Plate plate);
    }
}
