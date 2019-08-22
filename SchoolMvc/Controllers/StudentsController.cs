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

        // [HttpPost]
        // public IActionResult Create(StudentsController student)
        // {
        //     StudentsController.PostStudent(student);
        //     return RedirectToAction("Index");
        // }

        public IActionResult Details(int id)
        {
            var thisStudent = Student.GetThisStudent(id);
            return View(thisStudent);
        }
    }
}