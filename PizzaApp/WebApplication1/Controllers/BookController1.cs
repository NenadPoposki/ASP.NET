using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController1 : Controller
    {
        //[Route("Kniga/[Action]")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listbooks()
        {
            return RedirectToAction("Index");
        }
        
        public IActionResult BookTop()
        {
            return RedirectToAction("Privacy", "Home");
        }

        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        public IActionResult GetJsonBook()
        {
            Book book = new Book()
            {
                Id = 1,
                Title = "Zoki Poki"
            };
            return new JsonResult(book);
        }

        public IActionResult Detals(int? id)
        {
            if(id == null)
            {
                return EmptyResult();
            }
            Book book = StaticDb Books.FirstOrDefault(x => x.Id == id);
            if(book == null)
            {
                return new EmptyResult();
            }
            return View(book);
        }

        private IActionResult EmptyResult()
        {
            throw new NotImplementedException();
        }
    }
}
