using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraineeManagement.Models;

namespace TraineeManagement.Controllers
{
    public class HomeController : Controller
    {
        DSQLiteContactManagementdbContext
        DSQLiteContactManagementdbContext= new DSQLiteContactManagementdbContext();
        public IActionResult Index()
        {
        
                    return View(DSQLiteContactManagementdbContext.Contacts.ToList());
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
