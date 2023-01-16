using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Back_end.Data;
using Back_end.Helpers;
using Back_end.Models;
using Back_end.ViewModels.CategoryViewModels;
using Back_end.ViewModels.SubCategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Back_end.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 3)
        {
            List<Category> categories = await _context.Category
                .Where(m => !m.IsDeleted)
                .OrderByDescending(m => m.Id)
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();

            List<CategoryListVM> mapDatas = GetMapDatas(categories);

            int count = await GetPageCount(take);

            Paginate<CategoryListVM> result = new Paginate<CategoryListVM>(mapDatas, page, count);

            return View(result);
        }

        private async Task<int> GetPageCount(int take)
        {
            int categoryCount = await _context.Category.Where(m => !m.IsDeleted).CountAsync();

            return (int)Math.Ceiling((decimal)categoryCount / take);
        }

        private List<CategoryListVM> GetMapDatas(List<Category> categories)
        {
            List<CategoryListVM> categoryList = new List<CategoryListVM>();

            foreach (var category in categories)
            {
                CategoryListVM newCategory = new CategoryListVM
                {
                    Id = category.Id,
                    Name = category.Name
                };

                categoryList.Add(newCategory);
            }

            return categoryList;
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryCreateVM category)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(category);
                }

                bool isExist = await _context.Category.AnyAsync(m => m.Name.Trim() == category.Name.Trim());

                if (isExist)
                {
                    ModelState.AddModelError("Name", "Category already exist!");
                    return View();
                }

                Category newCategory = new Category
                {
                    Name = category.Name,
                };

                await _context.Category.AddAsync(newCategory);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                ViewBag.Message = exception.Message;
                return View();
            }
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            Category category = await _context.Category
                .Where(m => !m.IsDeleted && m.Id == id)
                .FirstOrDefaultAsync();

            if (category == null) return NotFound();

            CategoryListVM categoryDetail = new CategoryListVM
            {
                Id = category.Id,
                Name = category.Name,
            };

            return View(categoryDetail);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id is null) return BadRequest();

            Category dbCategory = await GetByIdAsync((int)id);

            CategoryUpdateVM updateCategory = new CategoryUpdateVM
            {
                Id = dbCategory.Id,
                Name = dbCategory.Name
            };

            return View(updateCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, CategoryUpdateVM updateCategory)
        {
            if (!ModelState.IsValid) return View(updateCategory);

            Category dbCategory = await GetByIdAsync(id);

            dbCategory.Name = updateCategory.Name;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            Category category = await _context.Category
                .Where(m => !m.IsDeleted && m.Id == id)
                .FirstOrDefaultAsync();

            if (category == null)
            {
                return NotFound();
            }

            category.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Category
                .Where(m => !m.IsDeleted && m.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
