using CollectionOfClassMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CollectionOfClassMVC1.Controllers
{
    public class HomeController : Controller
    {
        Contact Anjali = new Contact()
        {
            Name = "Anjali" ,Location = "Ernakulam"

        };
        public IActionResult Index()
        {
            ViewBag.Contact = Anjali;
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
