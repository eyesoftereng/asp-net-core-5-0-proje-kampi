using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>()
            {
                new UserComment()
                {
                    ID = 1,
                    Username = "Eren Gaygusuz"
                },
                new UserComment()
                {
                    ID = 2,
                    Username = "Tuğba Bozdağ"
                },
                new UserComment()
                {
                    ID = 3,
                    Username = "Esra Gedik"
                }
            };

            return View(commentValues);
        }
    }
}
