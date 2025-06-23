using IENUMERABLE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IENUMERABLE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Student> students = GetTopScorers(GetStudents());
            return View(students);
        }

        // Sample data
        private IEnumerable<Student> GetStudents()
        {
            yield return new Student { Name = "Alice", Marks = 85 };
            yield return new Student { Name = "Bob", Marks = 74 };
            yield return new Student { Name = "Charlie", Marks = 92 };
            yield return new Student { Name = "David", Marks = 67 };
            yield return new Student { Name = "Eva", Marks = 88 };
        }

        // Filter logic
        private IEnumerable<Student> GetTopScorers(IEnumerable<Student> students)
        {
            foreach (var s in students)
            {
                if (s.Marks >= 80)
                {
                    yield return s;
                }
            }
        }
    }

}
