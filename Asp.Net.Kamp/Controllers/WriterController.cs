using Asp.Net.Kamp.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Asp.Net.Kamp.Controllers
{
	[AllowAnonymous]
	public class WriterController : Controller
    {
        

        WriterManager wm = new WriterManager(new EfWriterRepository());

        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;  
            
            var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2=writerName;
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

      

        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
           

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.mail = values.Email;
            model.namesurname = values.NameSurname;
            model.imageurl = values.ImageUrl;
            model.username = values.UserName;
            return View(model);


        }

     
        [HttpPost]

       public  async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
        {


            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            value.NameSurname = model.namesurname;
            value.ImageUrl = model.imageurl;
            value.Email = model.mail;
            value.PasswordHash = _userManager.PasswordHasher.HashPassword(value, model.password);
            var result=await _userManager.UpdateAsync(value);
          
            return RedirectToAction("Index", "Dashboard");



        }




        [AllowAnonymous]
        [HttpGet]

        public IActionResult WriterAdd()
        {
            return View();
        }

		[AllowAnonymous]
		[HttpPost]

		public IActionResult WriterAdd(AddProfileImage p)
		{
            Writer w=new Writer();
            if (p.WriterImage!=null)
            {

                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }
            w.WriterMail = p.WriterMail;
            w.WriterName= p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterPassword2 = w.WriterPassword;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
			return RedirectToAction("Index", "Dashboard");
		}

       
	}
}
