using GenericMVCString.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GenericMVCString.Controllers
{
    public class HomeController: Controller
    {
        List<string> touristLocation = new List<string>()
        {
      
            "Areekkal WaterFall", "Kochaikal Cave" 
        };

        public IActionResult Index()
        {
            ViewBag.Locations = touristLocation;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
