using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About controller's Index action");
            return View();
        }
         public IActionResult History()
        {
            return Content("This is the About controller's History action");
            return View();
        }
         public IActionResult Location()
        {
            return Content("This is the About controller's Location action");
            return View();
        }
    }
}