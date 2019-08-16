using Cer.WebApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Infrastructure.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll(params string[] navigationProperties);
        IEnumerable<T> GetAll();
        IList<T> Find(Expression<Func<T, bool>> predicate, params string[] navigationProperties);
        T GetById(int id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        Task<IEnumerable<T>> GetAllAsync(params string[] navigationProperties);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IList<T>> FindAsync(Expression<Func<T, bool>> predicate, params string[] navigationProperties);
        Task<T> GetByIdAsync(int id);
        Task<T> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
      
    }
}