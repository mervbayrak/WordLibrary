
using System.ComponentModel.DataAnnotations.Schema;
using WordLibrary.Entities.Abstract;

namespace WordLibrary.Entities.Concrete
{
    public class Word : IEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        public string Mean { get; set; }
        [Column(TypeName = "varchar")]
        public string Pronounce { get; set; }
    }
}
