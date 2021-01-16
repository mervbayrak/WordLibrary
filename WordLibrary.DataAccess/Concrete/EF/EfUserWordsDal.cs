using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WordLibrary.Core.DataAccess.EF;
using WordLibrary.DataAccess.Abstract;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.DataAccess.Concrete.EF
{
    public class EfUserWordsDal : EfRepositoryBase<WordDBContext, UserWords>, IUserWordsDal
    {
        public override List<UserWords> GetList(Expression<Func<UserWords, bool>> filter = null)
        {
            return filter == null
                ? base._context.Set<UserWords>().Include(c => c.Word).ToList()
                : base._context.Set<UserWords>().Where(filter).Include(c => c.Word).ToList();
        }
        public override void Update(UserWords entity)
        {
            using (var context = new WordDBContext())
            {
                context.Set<UserWords>().Update(entity);
                context.SaveChanges();
            }
            //if (entity.Word != null) base._context.Entry<Word>(entity.Word).State = EntityState.Detached;
            //if (entity.User != null) base._context.Entry<User>(entity.User).State = EntityState.Detached;
            //
            //base._context.Set<UserWords>().Update(entity);
        }
    }
}
