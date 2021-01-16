using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.DataAccess.Abstract;
using WordLibrary.Core.DataAccess.EF;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.DataAccess.Concrete.EF
{
    public class EfFavoriteDal : EfRepositoryBase<WordDBContext, Favorite>, IFavoriteDal
    {
    }
}
