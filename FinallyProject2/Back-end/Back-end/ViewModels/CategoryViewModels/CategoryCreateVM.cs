using System.ComponentModel.DataAnnotations;

namespace Back_end.ViewModels.CategoryViewModels
{
    public class CategoryCreateVM
    {
        [Required]
        public string Name { get; set; }
    }
}
