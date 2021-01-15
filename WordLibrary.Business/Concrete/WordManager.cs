using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Business.Abstract;
using WordLibrary.Business.ValidationRules.FluentValidation;
using WordLibrary.DataAccess.Abstract;
using WordLibrary.Entities.Concrete;
using WordLibrary.Core.Aspects.Postsharp;
using WordLibrary.Core.Aspects.Postsharp.CacheAspects;
using WordLibrary.Core.CrossCuttingConcers.Caching.Microsoft;
using WordLibrary.Core.CrossCuttingConcers.Logging.Log4Net.Loggers;
using WordLibrary.Core.Aspects.Postsharp.LogAspects;

namespace WordLibrary.Business.Concrete
{
    public class WordManager : IWordService
    {
        private IWordDal _wordDal;
        private IUserWordsDal _userWordsDal;
        public WordManager(IWordDal wordDal, IUserWordsDal userWordsDal)
        {
            _wordDal = wordDal;
            _userWordsDal = userWordsDal;
        }
        ///Word
        [FluentValidationAspect(typeof(WordValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void SaveDb(Word a, CreateReason reason = CreateReason.Create)
        {
            _wordDal.SaveDb(a, reason);
        }
        public Word GetById(int id)
        {
            return _wordDal.Get(m => m.Id == id);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        public List<Word> GetList()
        {
            return _wordDal.GetList();
        }

        ///UserWords
        public void SaveDb(UserWords a, CreateReason reason)
        {
            _userWordsDal.SaveDb(a, reason);
        }
        public UserWords GetUWordById(int id)
        {
            return _userWordsDal.Get(m => m.Id == id);
        }
        public List<UserWords> GetListByUserId(int id)
        {
            return _userWordsDal.GetList(m => m.UserId == id && m.Display);
        }
    }
}
