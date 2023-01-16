using System.ComponentModel.DataAnnotations;

namespace Back_end.ViewModels.SubCategoryViewModels
{
    public class SubCategoryUpdateVM
    {
        public int Id { get; set; }

        [Required]
        public string SubCategory { get; set; }
        public int CategoryId { get; set; }
    }
}
