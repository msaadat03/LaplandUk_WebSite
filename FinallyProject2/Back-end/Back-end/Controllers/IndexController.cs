using Microsoft.AspNetCore.Mvc;

namespace Back_end.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
