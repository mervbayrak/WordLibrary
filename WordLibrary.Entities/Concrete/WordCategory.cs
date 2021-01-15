using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Entities.Abstract;

namespace WordLibrary.Entities.Concrete
{
    public class WordCategory : IEntity
    {
        public int Id { get; set; }
        public Word Word { get; set; }
        public int WordId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
