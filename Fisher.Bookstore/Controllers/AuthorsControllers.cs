using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
           // return Content("This is about the authors Index");
           return View();
        }

        public IActionResult Featured()
        {
           // return Content("This is about the authors featured");
           return View();
        }

    }
}