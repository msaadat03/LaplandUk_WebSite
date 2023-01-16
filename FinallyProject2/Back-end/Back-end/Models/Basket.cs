using System.Collections.Generic;

namespace Back_end.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public ICollection<BasketProduct> BasketProducts { get; set; }
    }
}
