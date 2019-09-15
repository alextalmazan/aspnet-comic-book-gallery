using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGalery.Controllers
{
    public class ComicBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Detail(string name, int numTimes)
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/ComicBook/Contact");
            }
            else
            {
                return Content("Hello form our Detail Result Method");
            }
        }
    }
}