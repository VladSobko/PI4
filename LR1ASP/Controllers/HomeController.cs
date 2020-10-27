using LR1ASP.Models;
using System.Collections.Generic;
using System.Linq;
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
        [HttpGet]
        public ActionResult Add()
        {
            IEnumerable<Student> student = db.Students;

            ViewBag.Student = student;
            return View();
        }
        [HttpPost]
        public ActionResult Add(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Student student = db.Students.FirstOrDefault(p => p.Id == id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student student = db.Students.Find(id);
            ViewBag.Student = student;
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Student student, int id)
        {

            Student old_student  = db.Students.FirstOrDefault(p => p.Id == student.Id);

            old_student.Name = student.Name;
            old_student.Surname = student.Surname;
            old_student.Group = student.Group;
            old_student.Course = student.Course;
            old_student.English = student.English;
            old_student.Math = student.Math;
            old_student.WebProgramming = student.WebProgramming;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}