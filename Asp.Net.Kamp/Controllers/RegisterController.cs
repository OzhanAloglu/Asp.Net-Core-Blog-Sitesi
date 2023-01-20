using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FluentValidation.Results;
using FluentValidation.AspNetCore;
using Asp.Net.Kamp.Models;
using Microsoft.AspNetCore.Authorization;

namespace Asp.Net.Kamp.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
      
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            //Dropdownlist ile verileri çekme işlemi

            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "İstanbul", Value = "0" });
            items.Add(new SelectListItem { Text = "Ankara", Value = "1" });
            items.Add(new SelectListItem { Text = "İzmir", Value = "2" });
            items.Add(new SelectListItem { Text = "Antalya", Value = "3" });
            items.Add(new SelectListItem { Text = "Bursa", Value = "4" });
            items.Add(new SelectListItem { Text = "Muğla", Value = "5" });

            ViewBag.sehir = items;
            return View();

        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult results = wv.Validate(p);

            if (results.IsValid && p.WriterPassword == p.WriterPassword2)
            {

                p.WriterStatus = true;
                p.WriterAbout = "Deneme Test";
                wm.TAdd(p);
                return RedirectToAction("Index", "Writer");
            }

            else if (!results.IsValid)

            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            else
            {
                ModelState.AddModelError("WriterPassword", "Girdiğiniz Şifreler Eşleşmedi Lütfen Tekrar Deneyin");
            }

            return View();

        }













    }
}
