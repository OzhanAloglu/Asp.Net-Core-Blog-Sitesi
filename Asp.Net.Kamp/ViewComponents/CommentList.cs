using Asp.Net.Kamp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Kamp.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues=new List<UserComment>()
            {
                new UserComment
                {
                    ID= 1,
                    UserName="öZHAN"
                },

                new UserComment
                {
                    ID= 2,
                    UserName="Mesut"
                },

                 new UserComment
                 {
                     ID = 3,
                     UserName = "Beyza"
                 }

            };
            return View(commentvalues);
        }


    }
}
