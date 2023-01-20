using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Asp.Net.Kamp.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c= new Context();
        public IViewComponentResult Invoke()
        {
            //Toplam Blog Sayısını Index te yazdırma.
            ViewBag.v1=bm.GetList().Count();
            ViewBag.v2=c.Contacts.Count();
            ViewBag.v3=c.Comments.Count();
            string api = "d3494ca056c740e293c4e72988ba7b31";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument xDocument = XDocument.Load(connection);
            ViewBag.v4 = xDocument.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
           

        }



    }
}
