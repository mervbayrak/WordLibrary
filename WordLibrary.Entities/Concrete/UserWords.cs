using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Entities.Abstract;

namespace WordLibrary.Entities.Concrete
{
    public class UserWords : IEntity
    {
        public int Id { get; set; }
        public  User User { get; set; }
        public int UserId { get; set; }
        public Word Word { get; set; }
        public int WordId { get; set; }
        public int DisplayCount { get; set; }
        public bool Display { get; set; }
    }
}
