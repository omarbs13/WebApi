using Cer.WebApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Domain.Interface
{
    public interface IUserDomain
    {
        IEnumerable<User> GetAll(string[] navigationProperties = null);
        IList<User> Find(Expression<Func<User, bool>> predicate, string[] navigationProperties = null);
        User GetById(int id);
        bool Insert(User user);
        bool Update(User user);
        bool Delete(int id);
        Task<IEnumerable<User>> GetAllAsync(string[] navigationProperties = null);
        Task<IList<User>> FindAsync(Expression<Func<User, bool>> predicate, string[] navigationProperties = null);
        Task<User> GetByIdAsync(int id);
        Task<User> InsertAsync(User user);
        Task<bool> UpdateAsync(User user);
        Task<int> DeleteAsync(int id);
    }
}
