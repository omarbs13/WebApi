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

        public async Task<bool> DeleteAsync(T entity)
        {
            _entities.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public IList<T> Find(Expression<Func<T, bool>> predicate, string[] entities = null)
        {
            List<T> list;

            var query = _context.Set<T>().AsQueryable();
            if (entities != null)
                foreach (string navigationProperty in entities)
                    query = query.Include(navigationProperty);

            list = query.Where(predicate).ToList<T>();

            return list.Where(x => x.Status).ToList();
        }

        public async Task<IList<T>> FindAsync(Expression<Func<T, bool>> predicate, string[] entities = null)
        {
            List<T> list;

            var query = _context.Set<T>().AsQueryable();
            if (entities != null)
                foreach (string navigationProperty in entities)
                    query = query.Include(navigationProperty);

            list = await query.Where(predicate).ToListAsync<T>();

            return list.Where(x => x.Status).ToList();
        }

        public IEnumerable<T> GetAll(string[] entities = null)
        {
            List<T> list;

            var query = _context.Set<T>().AsQueryable();
            if (entities != null)
                foreach (string navigationProperty in entities)
                    query = query.Include(navigationProperty);

            list = query.Where(x => x.Status).ToList<T>();

            return list;
        }

        public async Task<IEnumerable<T>> GetAllAsync(string[] entities = null)
        {
            List<T> list;

            var query = _context.Set<T>().AsQueryable();
            if (entities != null)
                foreach (string navigationProperty in entities)
                    query = query.Include(navigationProperty);

            list = await query.Where(x => x.Status).ToListAsync<T>();

            return list;
        }


        public T GetById(int id)
        {
            return _entities.SingleOrDefault(s => s.Id == id && s.Status);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.SingleOrDefaultAsync(s => s.Id == id && s.Status);
        }

        public T Insert(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<T> InsertAsync(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
