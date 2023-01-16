using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public ICollection<ProductSubCategory> ProductSubCategories { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
