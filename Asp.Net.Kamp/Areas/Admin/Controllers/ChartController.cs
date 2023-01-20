using Asp.Net.Kamp.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Kamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //CategoryClass a yeni veriler eklemek için.
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list= new List<CategoryClass>();

            list.Add(new CategoryClass
            
            { 
                categoryName="Teknoloji",
                categoryCount=10
            
            });

            list.Add(new CategoryClass

            {
                categoryName = "Yazılım",
                categoryCount = 14

            });

            list.Add(new CategoryClass

            {
                categoryName = "Spor",
                categoryCount = 5   

            });
            list.Add(new CategoryClass

            {
                categoryName = "Sinema",
                categoryCount = 3

            });

            return Json(new {jsonlist=list});
        }
    }
}
