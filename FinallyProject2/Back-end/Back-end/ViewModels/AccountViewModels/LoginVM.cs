using System.ComponentModel.DataAnnotations;

namespace Back_end.ViewModels.AccountViewModels
{
    public class LoginVM
    {
      [Required]
    public string EmailOrUsername { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
}
