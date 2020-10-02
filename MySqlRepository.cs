using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace helloentity
{
    public class MySqlRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly HelloentityContext _context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public MySqlRepository(HelloentityContext context)
        {
            this._context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.SelectMany\
        }

        public T Get(int id, bool isActive = true)
        {
            return entities.FirstOrDefault(s => s.Id == id && (s.Active || !isActive));
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> filter)
        {
            return entities.Where(filter);
        }

        // public IEnumerable<T> Include(Expression<Func<T, IEnumerable<T>>> filter)
        // {
        //     return entities.Include(filter);
        // }

        public void Insert(T entity, bool saveChange = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entity.CreatedTime = DateTime.Now;
            entity.UpdatedTime = DateTime.Now;

            entities.Add(entity);

            if (saveChange)
                this._context.SaveChanges();

        }

        public void Update(T entity, bool saveChange = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.UpdatedTime = DateTime.Now;
            if (saveChange)
                this._context.SaveChanges();
        }

        public void Delete(T entity, bool saveChange = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            if (saveChange)
                this._context.SaveChanges();
        }
    }
}