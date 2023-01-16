using System.ComponentModel.DataAnnotations;

namespace Back_end.ViewModels.CategoryViewModels
{
    public class SubCategoryCreateVM
    {
        [Required]
        public string SubCategory { get; set; }
        public int CategoryId { get; set; }
    }
}
