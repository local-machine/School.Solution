using Microsoft.AspNetCore.Mvc;
using SchoolMvc.Models;

namespace SchoolMvc.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            var allStudent = Student.GetAllStudents();
            return View(allStudent);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            Student.CreateStudent(student);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            var thisStudent = Student.GetThisStudent(id);
            return View(thisStudent);
        }

        [HttpPut]
        public IActionResult Edit(Student student, int id)
        {
            Student.EditStudent(student, id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var thisStudent = Student.GetThisStudent(id);
            return View(thisStudent);
        }
    }
}