using Back_end.Data;
using Back_end.Models;
using Back_end.Services.Interfaces;
using Back_end.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_end.Controllers
{
    public class Tickets : Controller
    {
        private readonly AppDbContext _context;


        public Tickets(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            TicketsTitle ticketsTitles = await _context.TicketsTitles.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            TicketAbout ticketAbouts = await _context.TicketAbouts.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            List<Faqs> faqs = await _context.Faqsses.Where(m => !m.IsDeleted).ToListAsync();


            TicketsVM model = new TicketsVM
            {
                
                TicketsTitles = ticketsTitles,
                TicketAbouts = ticketAbouts,
                Faqsses = faqs
            };

            return View(model);
        }
    }
}
