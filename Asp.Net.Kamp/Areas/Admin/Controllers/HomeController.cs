using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Kamp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
