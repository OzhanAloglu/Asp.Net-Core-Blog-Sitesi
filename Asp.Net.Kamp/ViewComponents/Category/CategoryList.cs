﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Kamp.ViewComponents.Category
{

    
    public class CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());


        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);
        }




    }

    

}
