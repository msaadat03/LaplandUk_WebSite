using Microsoft.AspNetCore.Http;
using Back_end.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Back_end.ViewModels.ProductViewModels
{
    public class ProductUpdateVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        [Required]
        public List<IFormFile> Photos { get; set; }
    }
}
