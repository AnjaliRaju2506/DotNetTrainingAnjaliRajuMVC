using Microsoft.AspNetCore.Mvc;
using ObjectVIewBagMVC.Models;
using System.Diagnostics;

namespace ObjectVIewBagMVC.Controllers
{
    public class HomeController : Controller
    {
        Contact Anjali = new Contact()
        {
            Name = "Anjali",
            Location = "Ernakulam"
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
    }
}
