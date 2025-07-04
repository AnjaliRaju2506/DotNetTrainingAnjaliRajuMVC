using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraineeSelectDetails.Models;

namespace TraineeSelectDetails.Controllers
{
    public class HomeController : Controller
    {
        ContactManagementdbContext tocHTraineesContext=new ContactManagementdbContext();
        public IActionResult Index()
        {
            return View(tocHTraineesContext.Contacts.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Contact trainee)
        {

            tocHTraineesContext.Contacts.Add(trainee);
            tocHTraineesContext.SaveChanges();
            return RedirectToAction("Index");

            return View(trainee);
        }
        public IActionResult Details(int id)
        {
            var trainee = tocHTraineesContext.Contacts.Find(id);

            return View(trainee);

        }

        public IActionResult Delete(int id)
        {
            var trainee = tocHTraineesContext.Contacts.Find(id);
            return View(trainee);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var trainee = tocHTraineesContext.Contacts.Find(id);
            tocHTraineesContext.Contacts.Remove(trainee);
            tocHTraineesContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var trainee = tocHTraineesContext.Contacts.Find(id);
            return View(trainee);
        }
        [HttpPost]
        public IActionResult Edit(Contact trainee)
        {
            var tr = tocHTraineesContext.Contacts.Find(trainee.Id);
            tr.Name = trainee.Name;
            tr.Location = trainee.Location;
            tocHTraineesContext.SaveChanges();
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