using Microsoft.AspNetCore.Mvc;
using SchoolMvc.Models;

namespace SchoolMvc.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var allCourses = Course.GetAllCourses();
            return View(allCourses);
        }

        public ActionResult Create()
        {
            return View();
        }

        // [HttpPost]
        // public IActionResult Create(CoursesController course)
        // {
        //     Course.PostCourse(course);
        //     return RedirectToAction("Index");
        // }

        public IActionResult Details(int id)
        {
            var thisCourse = Course.GetThisCourse(id);
            return View(thisCourse);
        }


    }
}