using System.ComponentModel.DataAnnotations;

namespace Back_end.ViewModels.AccountViewModels
{
    public class RegisterVM
    { 
        [Required]
    public string Name { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password), Compare(nameof(Password))]
    public string RepeatPassword { get; set; }
}
}
