using Back_end.Data;
using Back_end.Models;
using Back_end.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Back_end.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Contact contact = await _context.Contacts.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

            ContactVM model = new ContactVM
            {
                Contact = new Contact()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Contact contactUs)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    Contact contact = await _context.Contacts.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

                    ContactVM model = new ContactVM
                    {
                        Contact = contact,
                    };

                    return View(model);
                }

                bool isExist = await _context.Contacts.AnyAsync(m =>
                m.Name.Trim() == contactUs.Name.Trim() &&
                m.Name.Trim() == contactUs.Surname.Trim() &&
                m.PhoneNumber.Trim() == contactUs.PhoneNumber.Trim() &&
                m.Email.Trim() == contactUs.Email.Trim() &&
                m.Message.Trim() == contactUs.Message.Trim());

                if (isExist)
                {
                    ModelState.AddModelError("Name", "Subject already exist!");
                }

                await _context.Contacts.AddAsync(contactUs);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
