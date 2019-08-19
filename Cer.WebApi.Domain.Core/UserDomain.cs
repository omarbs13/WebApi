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

        public async Task<bool> DeleteAsync(int id)
        {
            return await _userRepository.DeleteAsync(id);
        }

        public IList<User> Find(Expression<Func<User, bool>> predicate, string[] navigationProperties=null)
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

        public User Insert(User user)
        {
            return _userRepository.Insert(user);
        }

        public async Task<User> InsertAsync(User user)
        {
            return await _userRepository.InsertAsync(user);
        }

        public User Update(User user)
        {
            return _userRepository.Update(user);
        }

        public async Task<User> UpdateAsync(User user)
        {
            return await _userRepository.UpdateAsync(user);
        }
    }
}
