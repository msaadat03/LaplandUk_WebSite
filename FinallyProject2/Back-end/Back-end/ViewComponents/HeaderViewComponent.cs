using Back_end.Data;
using Back_end.Models;
using Back_end.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Back_end.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HeaderViewComponent(UserManager<AppUser> userManager,
            IHttpContextAccessor httpContextAccessor,
            AppDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> GetUserBasketProductsCount(ClaimsPrincipal userClaims)
        {
            var user = await _userManager.GetUserAsync(userClaims);
            if (user == null) return 0;
            var basketProductCount = await _context.BasketProducts.Where(m => m.Basket.AppUserId == user.Id).SumAsync(m => m.Quantity);
            return basketProductCount;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HeaderVM model = new HeaderVM
            {
                Count = await GetUserBasketProductsCount(_httpContextAccessor.HttpContext.User)
            };

            return await Task.FromResult(View(model));
        }

    }
}
