using Back_end.Data;
using Back_end.Models;
using Back_end.ViewModels;
using Back_end.ViewModels.BasketViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_end.Controllers
{
    public class Shop : Controller
    {
        private readonly AppDbContext _context;

        public Shop(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.count = await _context.Product.Where(m => !m.IsDeleted).CountAsync();

            IEnumerable<Product> products = await _context.Product
                .Where(m => !m.IsDeleted)
                .Include(m => m.ProductImages)
                .Include(m => m.ProductSubCategories)
                .ThenInclude(m => m.SubCategory)
                .Take(8)
                .ToListAsync();
            IEnumerable<SubCategory> subCategories = await _context.SubCategory
                .Where(m => !m.IsDeleted)
                .ToListAsync();

            ShopVM model = new ShopVM
            {
                Products = products,
                SubCategories = subCategories,
            };

            return View(model);
        }

        public async Task<IActionResult> ShowMore(int skip)
        {
            IEnumerable<Product> products = await _context.Product
                .Where(m => !m.IsDeleted)
                .Include(m => m.ProductImages)
                .Include(m => m.ProductSubCategories)
                .ThenInclude(m => m.SubCategory)
                .Skip(skip)
                .Take(8)
                .ToListAsync();

            ShopVM model = new ShopVM
            {
                Products = products
            };

            return PartialView("_ProductPartial", model);
        }

        public IActionResult Search(string search)
        {
            List<Product> searchProduct = _context.Product.Include(m => m.ProductImages)
                .Where(m => m.Name.ToLower().Contains(search.ToLower()) && !m.IsDeleted)
                .ToList();
            ShopVM model = new ShopVM
            {
                Products = searchProduct,
            };
            return PartialView("_SearchProductPartial", model);
        }
    }
}

