using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Business.Abstract
{
    public interface IPlateDetailService
    {
        Task<List<PlateDetails>> GetAllEntityAsync(Expression<Func<PlateDetails, bool>> filter = null);

        Task<PlateDetails> GetEntityByIdentityAsync(Expression<Func<PlateDetails, bool>> filter);

        Task<int> DeleteEntityByIdentityAsync(int id);

        Task<PlateDetails> UpdateEntityAsync(PlateDetails entity);

        Task<PlateDetails> AddEntityAsync(PlateDetails entity);
    }
}
