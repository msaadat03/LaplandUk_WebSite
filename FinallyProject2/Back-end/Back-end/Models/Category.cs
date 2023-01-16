using System.Collections.Generic;

namespace Back_end.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategory { get; set; }
    }
}
