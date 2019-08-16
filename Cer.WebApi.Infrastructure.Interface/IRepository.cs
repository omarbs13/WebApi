using Cer.WebApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Infrastructure.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll(string[] navigationProperties = null);
        IList<T> Find(Expression<Func<T, bool>> predicate, string[] navigationProperties = null);
        T GetById(int id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        Task<IEnumerable<T>> GetAllAsync(string[] navigationProperties = null);
        Task<IList<T>> FindAsync(Expression<Func<T, bool>> predicate, string[] navigationProperties = null);
        Task<T> GetByIdAsync(int id);
        Task<T> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);

    }
}