using System.Collections.Generic;

namespace Back_end.ViewModels.BasketViewModels
{
    public class BasketIndexVM
    {
        public BasketIndexVM()
        {
            BasketProducts = new List<BasketProductVM>();
        }

        public List<BasketProductVM> BasketProducts { get; set; }
    }
}
