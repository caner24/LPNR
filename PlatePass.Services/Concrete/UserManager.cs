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

        public Task<List<User>> GetAllEntityAsync(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
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
