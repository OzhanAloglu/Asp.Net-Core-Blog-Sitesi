using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Kamp.ViewComponents.Blog
{

    public class BlogListDashboard:ViewComponent
    {
        

        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {

            //Son 5 blogu yazdırmak için.

            var values = bm.GetBlogListWithCategory().OrderByDescending(x=>x.BlogID).Take(5).ToList();
            return View(values);
        }



    }
}
