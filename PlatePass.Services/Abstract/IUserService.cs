using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Business.Abstract
{
    public interface IUserService
    {
        Task<List<User>> GetAllEntityAsync(Expression<Func<User, bool>> filter = null);

        Task<User> GetEntityByIdentityAsync(Expression<Func<User, bool>> filter);

        Task<int> DeleteEntityByIdentityAsync(int id);

        Task<User> UpdateEntityAsync(User entity);

        Task<User> AddEntityAsync(User entity);
    }
}
