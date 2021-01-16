using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Entities.Concrete;
using WordLibrary.Core.DataAccess;

namespace WordLibrary.DataAccess.Abstract
{
    public interface IUserWordsDal : IRepository<UserWords>
    {
    }
}
