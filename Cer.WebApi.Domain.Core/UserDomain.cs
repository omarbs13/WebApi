using Cer.WebApi.Domain.Entity;
using Cer.WebApi.Domain.Interface;
using Cer.WebApi.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Domain.Core
{
    public class UserDomain : IUserDomain
    {
        private readonly IUserRepository _userRepository;
        public UserDomain(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _userRepository.DeleteAsync(id);
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

        public bool Insert(User user)
        {
            return _userRepository.Insert(user);
        }

        public async Task<User> InsertAsync(User user)
        {
            return await _userRepository.InsertAsync(user);
        }

        public bool Update(User user)
        {
            return _userRepository.Update(user);
        }

        public async Task<bool> UpdateAsync(User user)
        {
            return await _userRepository.UpdateAsync(user);
        }
    }
}
