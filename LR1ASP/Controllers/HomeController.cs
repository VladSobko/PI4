using LR1ASP.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LR1ASP.Controllers
{
    public class HomeController : Controller
    {

        StudentMarksContext db = new StudentMarksContext();
        public ActionResult Index()
        {
            IEnumerable<Student> students = db.Students;
            ViewBag.Students = students;
            return View();
        }
        [HttpGet]
        public ActionResult ChangeMark(int id)
        {
            ViewBag.StudentId = id;
            return View();
        }
    }

}