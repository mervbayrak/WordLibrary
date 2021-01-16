using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Core.DataAccess.EF;
using WordLibrary.DataAccess.Abstract;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.DataAccess.Concrete.EF
{
    public class EfCategoryDal : EfRepositoryBase<WordDBContext, Category>, ICategoryDal
    {
    }
}
