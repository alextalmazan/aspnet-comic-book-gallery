using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using ComicBookGalery.Models;
using System.Diagnostics;

namespace ComicBookGalery.Controllers
{
    public class ComicBookController : Controller
    {

        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Detail(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
            
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}