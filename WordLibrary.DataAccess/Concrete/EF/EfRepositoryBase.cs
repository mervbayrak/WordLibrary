using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WordLibrary.DataAccess.Abstract;
using WordLibrary.Entities.Abstract;

namespace WordLibrary.DataAccess.Concrete.EF
{
    public class EfRepositoryBase<TContect, TEntity> : IRepository<TEntity>
        where TContect : DbContext, new()
        where TEntity : class, IEntity, new()
    {
        protected DbContext _context;
        public EfRepositoryBase()
        {
            var context = new TContect();
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            _context.Update(entity);
        }
        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }
        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().FirstOrDefault(filter);
        }
        public virtual List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _context.Set<TEntity>().ToList()
                : _context.Set<TEntity>().Where(filter).ToList();
        }
        public bool SaveDb(TEntity entity, CreateReason reason = CreateReason.Create)
        {
            switch (reason)
            {
                case CreateReason.Create:
                    Add(entity);
                    break;
                case CreateReason.Update:
                    Update(entity);
                    break;
                case CreateReason.Delete:
                    Delete(entity);
                    break;
            }
            return SaveAll();
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
