using SobriquetUsingView.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SobriquetUsingView.Controllers
{
    public class HomeController : Controller
    {


        public string Index(string id)
        {
            string sobriquet = "";
            if (id == "kochi")
            {
                sobriquet = "Queen Of Arabian Sea";
            }
            else if (id == "paris")
            {
                sobriquet = "City of Lights";
            }
            else if (id == "london")
            {
                sobriquet = "City of Fog";
            }
            else if (id == "newyork")
            {
                sobriquet = "Big Apple";
            }
            else
            {
                sobriquet = "Unknown City";
            }

            return sobriquet;
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