using System;
using Fisher.Bookstore.Models;
using Microsoft.AspNetCore.Mvc;


namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }
         public IActionResult Featured()
        {
           var featuredAuthor = new Author()
           {
               AuthorId = 1,
               Name = "J.K. Rowling" 
           };
           return View(featuredAuthor);
        }

    }
}