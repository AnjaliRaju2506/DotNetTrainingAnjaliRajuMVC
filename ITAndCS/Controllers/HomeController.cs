using ITAndCS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITAndCS.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.Name = "Anjali Raju";
            return View();
        }


        public IActionResult IT()
        {
                
            return View();
        }

        public IActionResult CS()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
