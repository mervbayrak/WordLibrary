using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Core.DataAccess;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.DataAccess.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
    }
}
