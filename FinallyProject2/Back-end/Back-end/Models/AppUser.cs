using Microsoft.AspNetCore.Identity;

namespace Back_end.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public Basket Basket { get; set; }
    }
}
