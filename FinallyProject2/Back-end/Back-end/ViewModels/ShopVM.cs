using Back_end.Models;
using System.Collections.Generic;

namespace Back_end.ViewModels
{
    public class ShopVM
    {
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
        public SubCategory SubCategory { get; set; }
        public IEnumerable<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
