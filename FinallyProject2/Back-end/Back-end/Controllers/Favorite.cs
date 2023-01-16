using Microsoft.AspNetCore.Mvc;

namespace Back_end.Controllers
{
    public class Favorite : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
