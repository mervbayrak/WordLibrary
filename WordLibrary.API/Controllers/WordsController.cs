using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordLibrary.Business.Abstract;
using WordLibrary.Core.DataAccess;
using WordLibrary.DataAccess.Abstract;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        private IWordService _wordService;
        public WordsController(IWordService wordDAL)
        {
            _wordService = wordDAL;
        }
        public ActionResult GetWords()
        {
            var words = _wordService.GetList();
            return Ok(words);
        }
        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] Word word)
        {
            _wordService.SaveDb(word, CreateReason.Create);
            return Ok(word);
        }
        [Route("userWords")]
        public ActionResult GetUserWords()
        {
            var lst = _wordService.GetListByUserId(1);
            var minDisplay = lst.Min(m=>m.DisplayCount);//Default değer olarak atandı
            //Sadece 1 değer gelmelidir.
            var uWord = lst.Where(m => m.DisplayCount == minDisplay).FirstOrDefault();

            return Ok(uWord);
        }
        [HttpPost]
        [Route("addUserWord")]
        public ActionResult Add([FromBody] UserWords uWord)
        {
            //_wordService.SaveDb(uWord.Word, CreateReason.Create);
            //uWord.WordId = uWord.Word.Id;
            _wordService.SaveDb(uWord, CreateReason.Create);
            return Ok(uWord);
        }
        [HttpPost]
        [Route("update")]
        public ActionResult Update([FromBody] UserWords uWord)
        {
            _wordService.SaveDb(uWord, CreateReason.Update);
            return Ok(uWord);
        }
    }
}
