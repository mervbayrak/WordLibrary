using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.DataAccess.Abstract;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.Business.Abstract
{
    public interface IWordService
    {
        void SaveDb(Word a, Core.DataAccess.CreateReason reason = Core.DataAccess.CreateReason.Create);
        Word GetById(int id);
        List<Word> GetList();
        void SaveDb(UserWords a, Core.DataAccess.CreateReason reason);
        UserWords GetUWordById(int id);
        List<UserWords> GetListByUserId(int id);
    }
}
