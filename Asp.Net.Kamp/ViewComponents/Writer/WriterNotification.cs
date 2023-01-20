using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Asp.Net.Kamp.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {

        NotificationManager nm = new NotificationManager(new EfNotificationRepository());

        public IViewComponentResult Invoke()
        {
          
                var values = nm.GetList();
          

            return View(values);

        }
    }
}
