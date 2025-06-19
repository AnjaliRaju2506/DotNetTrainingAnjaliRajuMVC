using CollectionOfClassMVC;
using CollectionOfClassMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CollectionOfClassMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
    return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

public IActionResult IT()
{
    return View();
}

}
}
