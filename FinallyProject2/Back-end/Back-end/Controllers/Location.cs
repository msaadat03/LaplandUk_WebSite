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
    public class Location : Controller
    {
        private readonly AppDbContext _context;

        public Location(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            LocationTitle locationTitles  = await _context.LocationTitles.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            List<CompasContent> compasContents  = await _context.CompasContents.Where(m => !m.IsDeleted).ToListAsync();
            GoldeBell goldeBells = await _context.GoldeBells.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            Compass compasses = await _context.Compasses.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            List<GoldenContents> goldenContentsses = await _context.GoldenContents.Where(m => !m.IsDeleted).ToListAsync();





            LocationVm model = new LocationVm
            {
               LocationTitles = locationTitles,
               CompasContents = compasContents,
               GoldeBells = goldeBells,
               Compasses = compasses,
               GoldenContentsses = goldenContentsses


            };

            return View(model);
        }
    }
}

