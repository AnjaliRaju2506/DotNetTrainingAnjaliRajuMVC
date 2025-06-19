using FormsMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormsMVC.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(string str)
        {
            string name = Request.Form["name"];
            string location = Request.Form["location"];
            ViewBag.Hello = $"Hello {name}, Located at {location}";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
