using Cer.WebApi.Domain.Entity;
using Cer.WebApi.Infrastructure.Interface;
using System;
using System.Collections.Generic;
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
        public bool Delete(int id)
        {
            return _userRepository.Delete(GetById(id));
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _userRepository.DeleteAsync(await GetByIdAsync(id));
        }

        public IList<User> Find(Expression<Func<User, bool>> predicate, params string[] navigationProperties)
        {
            return _userRepository.Find(predicate, navigationProperties);
        }

        public async Task<IList<User>> FindAsync(Expression<Func<User, bool>> predicate, params string[] navigationProperties)
        {
            return await _userRepository.FindAsync(predicate, navigationProperties);
        }

        public IEnumerable<User> GetAll(params string[] navigationProperties)
        {
            return _userRepository.GetAll(navigationProperties);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public async Task<IEnumerable<User>> GetAllAsync(params string[] navigationProperties)
        {
            return await _userRepository.GetAllAsync(navigationProperties);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public bool Insert(User entity)
        {
            return _userRepository.Insert(entity);
        }

        public async Task<User> InsertAsync(User entity)
        {
            return await _userRepository.InsertAsync(entity);
        }

        public bool Update(User entity)
        {
            return _userRepository.Update(entity);
        }

        public async Task<bool> UpdateAsync(User entity)
        {
            return await _userRepository.UpdateAsync(entity);
        }
    }
}
