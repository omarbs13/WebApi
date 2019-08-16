using Cer.WebApi.Domain.Entity;
using Cer.WebApi.Infraestructure.Data;
using Cer.WebApi.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private DbSet<T> _entities;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public bool Delete(T entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public async Task<int> DeleteAsync(T entity)
        {
            _entities.Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public IList<T> Find(Expression<Func<T, bool>> predicate, params string[] navigationProperties)
        {
            List<T> list;

            var query = _context.Set<T>().AsQueryable();

            foreach (string navigationProperty in navigationProperties)
                query = query.Include(navigationProperty);

            list = query.Where(predicate).ToList<T>();

            return list;
        }

        public async Task<IList<T>> FindAsync(Expression<Func<T, bool>> predicate, params string[] navigationProperties)
        {
            List<T> list;

            var query = _context.Set<T>().AsQueryable();

            foreach (string navigationProperty in navigationProperties)
                query = query.Include(navigationProperty);

            list = await query.Where(predicate).ToListAsync<T>();

            return list;
        }

        public IEnumerable<T> GetAll(params string[] navigationProperties)
        {
            List<T> list;

            var query = _context.Set<T>().AsQueryable();

            foreach (string navigationProperty in navigationProperties)
                query = query.Include(navigationProperty);

            list = query.ToList<T>();

            return list;
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public async Task<IEnumerable<T>> GetAllAsync(params string[] navigationProperties)
        {
            List<T> list;

            var query = _context.Set<T>().AsQueryable();

            foreach (string navigationProperty in navigationProperties)
                query = query.Include(navigationProperty);

            list = await query.ToListAsync<T>();

            return list;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public T GetById(int id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.SingleOrDefaultAsync(s => s.Id == id);
        }

        public bool Insert(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public async Task<T> InsertAsync(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public bool Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
