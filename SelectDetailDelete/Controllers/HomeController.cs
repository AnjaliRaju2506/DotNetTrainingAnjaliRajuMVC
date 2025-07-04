using Microsoft.AspNetCore.Mvc;
using SelectDetailDelete.Models;
using System.Diagnostics;

namespace SelectDetailDelete.Controllers
{
    public class HomeController : Controller
    {
        TocHTraineeContext tocHTraineeContext = new TocHTraineeContext();

        public IActionResult Index()
        {
            return View(tocHTraineeContext.Contacts.ToList());
        }

        public IActionResult Delete(int id)
        {
            var trainee = tocHTraineeContext.Contacts.Find(id);
            return View(trainee);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var trainee = tocHTraineeContext.Contacts.Find(id);
            tocHTraineeContext.Contacts.Remove(trainee);
            tocHTraineeContext.SaveChanges();
            return RedirectToAction("Index");


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