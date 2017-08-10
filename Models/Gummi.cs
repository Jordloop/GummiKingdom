using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiBearKing.Models
{
    [Table("Gummis")]
    public class Gummi
    {
        [Key]
        public int GummiId { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public int Cost { get; set; }

    }
}
