using Cer.WebApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Infrastructure.Interface
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll(params string[] navigationProperties);
        IEnumerable<User> GetAll();
        IList<User> Find(Expression<Func<User, bool>> predicate, params string[] navigationProperties);
        User GetById(int id);
        bool Insert(User entity);
        bool Update(User entity);
        bool Delete(int id);
        Task<IEnumerable<User>> GetAllAsync(params string[] navigationProperties);
        Task<IEnumerable<User>> GetAllAsync();
        Task<IList<User>> FindAsync(Expression<Func<User, bool>> predicate, params string[] navigationProperties);
        Task<User> GetByIdAsync(int id);
        Task<User> InsertAsync(User entity);
        Task<bool> UpdateAsync(User entity);
        Task<int> DeleteAsync(int id);
    }
}
