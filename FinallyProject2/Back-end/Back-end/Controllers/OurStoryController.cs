using Back_end.Data;
using Back_end.Models;
using Back_end.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_end.Controllers
{
    public class OurStoryController : Controller
    {
        private readonly AppDbContext _context;

        public OurStoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            OurStoryTitle ourStoryTitles = await _context.OurStoryTitles.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            List<RedBook> redBooks = await _context.RedBooks.Where(m => !m.IsDeleted).ToListAsync();
            RedBookimg redBookimgs = await _context.RedBookimgs.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            List<RedBookPage> redBookPages = await _context.RedBookPages.Where(m => !m.IsDeleted).ToListAsync();
            RedBookApp redBookApps = await _context.RedBookApps.Where(m => !m.IsDeleted).FirstOrDefaultAsync();






            OurStoryVM model = new OurStoryVM
            {
                OurStoryTitles = ourStoryTitles,
                RedBooks = redBooks,
                RedBookimgs = redBookimgs,
                RedBookPages = redBookPages,
                RedBookApps = redBookApps


            };

            return View(model);
        }
    }
}

