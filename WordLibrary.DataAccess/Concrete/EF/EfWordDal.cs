using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.DataAccess.Abstract;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.DataAccess.Concrete.EF
{
    public class EfWordDal : EfRepositoryBase<WordDBContext, Word>, IWordDal
    {
    }
}
