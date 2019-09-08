using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private ASSESSMENTContext ORM = null;
        public HomeController(ASSESSMENTContext _ORM)
        {
            ORM = _ORM;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Category C)
        {
            ORM.Category.Add(C);
            ORM.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(PostTable P)
        {
            ORM.PostTable.Add(P);
            ORM.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult AllCategories()
        {

            return View(ORM.Category.ToList());
        }

        [HttpGet]
        public IActionResult PostCategories()
        {

            return View(ORM.PostTable.ToList());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
