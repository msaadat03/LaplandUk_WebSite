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
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<Logo> logos = await _context.Logos.Where(m => !m.IsDeleted).ToListAsync();
            List<JourneySlider> journeysliders = await _context.JourneySliders.Where(m => !m.IsDeleted).ToListAsync();
            HomeWorld homeworlds = await _context.HomeWorlds.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            HomeInvitation homeInvitation = await _context.HomeInvitations.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            HomeAdventure homeAdventure = await _context.HomeAdventures.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            HomeGallery homeGallery = await _context.HomeGalleries.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            List<SliderContent> sliderContents = await _context.SliderContents.Where(m => !m.IsDeleted).ToListAsync();
            List<SliderGallery> sliderGalleries = await _context.SliderGalleries.Where(m => !m.IsDeleted).ToListAsync();
            HomeMeet homeMeet = await _context.HomeMeets.Where(m => !m.IsDeleted).FirstOrDefaultAsync();





            HomeVM model = new HomeVM
            {
                Logos = logos,
                HomeWorlds = homeworlds,
                HomeInvitations = homeInvitation,
                HomeAdventures = homeAdventure,
                JourneySliders = journeysliders,
                HomeGalleries = homeGallery,
                SliderContents = sliderContents,
                SliderGalleries = sliderGalleries,
                HomeMeets = homeMeet
            };

            return View(model);
        }
    }
}
