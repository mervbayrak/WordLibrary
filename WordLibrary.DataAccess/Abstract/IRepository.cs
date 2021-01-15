using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WordLibrary.Entities.Abstract;

namespace WordLibrary.DataAccess.Abstract
{
    public interface IRepository<T> where T :  class, IEntity, new()
    {
        void Add(T entity);
        abstract void Update(T entity);
        void Delete(T entity);
        bool SaveDb(T entity, CreateReason reason = CreateReason.Create);
        bool SaveAll();
        abstract T Get(Expression<Func<T, bool>> filter);
        abstract List<T> GetList(Expression<Func<T, bool>> filter = null);
    }
}
