using System.ComponentModel.DataAnnotations;

namespace Back_end.ViewModels.AccountViewModels
{
    public class ForgetPasswordVM
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
