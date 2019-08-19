using Cer.WebApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Infrastructure.Interface
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll(string[] navigationProperties = null);
        IList<User> Find(Expression<Func<User, bool>> predicate, string[] navigationProperties = null);
        User GetById(int id);
        User Insert(User entity);
        User Update(User entity);
        bool Delete(int id);
        Task<IEnumerable<User>> GetAllAsync(string[] navigationProperties = null);
        Task<IList<User>> FindAsync(Expression<Func<User, bool>> predicate, string[] navigationProperties = null);
        Task<User> GetByIdAsync(int id);
        Task<User> InsertAsync(User entity);
        Task<User> UpdateAsync(User entity);
        Task<bool> DeleteAsync(int id);
        User Authenticate(string username, string password);
    }
}
