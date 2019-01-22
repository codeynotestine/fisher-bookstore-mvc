using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is about the controllers Index");
        }

        public IActionResult History()
        {
            return Content("This is about the controllers History");
        }

        public IActionResult Location()
        {
            return Content("This is about the controllers Location");
        }
    }
}