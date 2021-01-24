using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Business.Abstract;
using WordLibrary.Business.ValidationRules.FluentValidation;
using WordLibrary.Entities.Concrete;
using WordLibrary.Core.Aspects.Postsharp;
using WordLibrary.Core.Aspects.Postsharp.CacheAspects;
using WordLibrary.Core.CrossCuttingConcers.Caching.Microsoft;
using WordLibrary.Core.CrossCuttingConcers.Logging.Log4Net.Loggers;
using WordLibrary.Core.Aspects.Postsharp.LogAspects;
using WordLibrary.DataAccess.Abstract;
using AutoMapper;
using WordLibrary.Core.Utilities.Mappings;

namespace WordLibrary.Business.Concrete
{
    public class WordManager : IWordService
    {
        private IWordDal _wordDal;
        private IUserWordsDal _userWordsDal;
        private IMapper _mapper;
        public WordManager(IWordDal wordDal, IUserWordsDal userWordsDal, IMapper mapper)
        {
            _wordDal = wordDal;
            _userWordsDal = userWordsDal;
            _mapper = mapper;
        }
        ///Word
        [FluentValidationAspect(typeof(WordValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void SaveDb(Word a, Core.DataAccess.CreateReason reason = Core.DataAccess.CreateReason.Create)
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
            //return _wordDal.GetList();

            //var words = AutoMapperHelper.MapToSameTypeList(_wordDal.GetList());


            var words = _mapper.Map<List<Word>>(_wordDal.GetList());
            return words;
        }

        ///UserWords
        public void SaveDb(UserWords a, Core.DataAccess.CreateReason reason)
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
