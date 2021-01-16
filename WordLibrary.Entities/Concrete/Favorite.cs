using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Core.Entities;

namespace WordLibrary.Entities.Concrete
{
    public class Favorite : IEntity
    {
        public int Id { get; set; }
        public UserWords UserWords { get; set; }
        public int UserWordId { get; set; }
    }
}
