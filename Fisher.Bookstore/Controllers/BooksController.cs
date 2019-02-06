using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
   [Route("books")]
    public class BooksController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            //return Content("This is about the books Index");
            return View();
        }

        [Route("new")]
        public IActionResult New()
        {
            //return Content("This is about the books new");
            return View();

        }

        [Route("best-sellers")]
        public IActionResult Best()
        {
            //return Content("This is about the books best");
            return View();
        }
    }
}