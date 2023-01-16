using Back_end.Models;
using System.Collections.Generic;

namespace Back_end.ViewModels.ProductViewModels
{
    public class ProductDetailVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public ICollection<ProductImage> Images { get; set; }
    }
}
