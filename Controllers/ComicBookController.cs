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

        public string Detail()
        {
            return "Hello from the comic books controller";
        }
    }
}