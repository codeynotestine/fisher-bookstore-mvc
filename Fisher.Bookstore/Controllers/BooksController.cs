using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is about the books Index");
        }

        public IActionResult New()
        {
            return Content("This is about the books new");
        }

        public IActionResult Best()
        {
            return Content("This is about the books best");
        }
    }
}