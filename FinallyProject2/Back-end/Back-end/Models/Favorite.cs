using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end.Models
{
    public class Favorite : BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
    }
}
