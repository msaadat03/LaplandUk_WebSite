using System.ComponentModel.DataAnnotations;

namespace Back_end.ViewModels.CategoryViewModels
{
    public class CategoryUpdateVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
