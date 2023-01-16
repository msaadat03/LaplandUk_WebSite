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
    public class ProductDetail : Controller
    {
        private readonly AppDbContext _context;

        public ProductDetail(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Product product = await _context.Product
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.ProductImages)
                .FirstOrDefaultAsync();

            ProductSubCategory productSubCategory = await _context.ProductSubCategory
               .Where(n => n.ProductId == id && n.SubCategory.CategoryId == 1)
               .Include(n => n.SubCategory)
               .FirstOrDefaultAsync();

            SubCategory subCategory = productSubCategory.SubCategory;

            ShopVM model = new ShopVM
            {
                Product = product,
                SubCategory = subCategory
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id is null) return BadRequest();

            var dbProduct = await GetProductById(id);

            if (dbProduct == null) return NotFound();

            List<BasketVM> basket = GetBasket();

            UpdateBasket(basket, dbProduct.Id);

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

            return Ok();
        }

        private void UpdateBasket(List<BasketVM> basket, int id)
        {
            BasketVM existProduct = basket.FirstOrDefault(m => m.Id == id);

            if (existProduct == null)
            {
                basket.Add(new BasketVM
                {
                    Id = id,
                    Count = 1
                });
            }
            else
            {
                existProduct.Count++;
            }
        }

        private async Task<Product> GetProductById(int? id)
        {
            return await _context.Product.FindAsync(id);
        }


        private List<BasketVM> GetBasket()
        {
            List<BasketVM> basket;

            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }

            return basket;
        }
    }
}
