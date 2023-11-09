using Microsoft.EntityFrameworkCore;
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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task<User> AddEntityAsync(User entity)
        {
            var returnedEntity = await _userDal.AddEntityAsync(entity);
            if (returnedEntity == null)
                throw new Exception(" Ürün Eklenirken Bir Hata Oluştu !.");
            return entity;
        }

        public async Task<int> DeleteEntityByIdentityAsync(int id)
        {
            var searchedUser = await GetEntityByIdentityAsync(x => x.Id == id);
            if (searchedUser == null)
                throw new Exception(" Aradığınız Kullanici Bulunamadi !.");
            return await _userDal.DeleteEntityByIdentityAsync(searchedUser);
        }

        public async Task<List<User>> GetAllEntityAsync(Expression<Func<User, bool>> filter = null)
        {
            return filter == null ? await _userDal.GetAllEntityAsync().Include(x => x.Plates).ToListAsync() : await _userDal.GetAllEntityAsync(filter).Include(x => x.Plates).ToListAsync();
        }

        public Task<User> GetEntityByIdentityAsync(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateEntityAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
