using Cer.WebApi.Domain.Entity;
using Cer.WebApi.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private IRepository<User> _userRepository;
        public UserRepository(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User Authenticate(string username, string password)
        {
            return _userRepository.Find(x => x.UserName == username && x.Password == password).FirstOrDefault();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            return user != null ? _userRepository.Delete(user) : false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            return user != null ? await _userRepository.DeleteAsync(user) : false;
        }

        public IList<User> Find(Expression<Func<User, bool>> predicate, string[] navigationProperties = null)
        {
            return _userRepository.Find(predicate, navigationProperties);
        }

        public async Task<IList<User>> FindAsync(Expression<Func<User, bool>> predicate, string[] navigationProperties = null)
        {
            return await _userRepository.FindAsync(predicate, navigationProperties);
        }

        public IEnumerable<User> GetAll(string[] navigationProperties = null)
        {
            return _userRepository.GetAll(navigationProperties);
        }

        public async Task<IEnumerable<User>> GetAllAsync(string[] navigationProperties = null)
        {
            return await _userRepository.GetAllAsync(navigationProperties);
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public User Insert(User entity)
        {
            return _userRepository.Insert(entity);
        }

        public async Task<User> InsertAsync(User entity)
        {
            return await _userRepository.InsertAsync(entity);
        }

        public User Update(User entity)
        {
            return _userRepository.Update(entity);
        }

        public async Task<User> UpdateAsync(User entity)
        {
            return await _userRepository.UpdateAsync(entity);
        }
    }
}
