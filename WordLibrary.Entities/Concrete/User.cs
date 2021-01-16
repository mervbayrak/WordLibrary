using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Core.Entities;

namespace WordLibrary.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
