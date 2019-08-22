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

        [HttpPost]
        public IActionResult Create(Course course)
        {
            Course.CreateCourse(course);
            return RedirectToAction("Index");
        }


        public ActionResult Edit()
        {
            return View();
        }

        [HttpPut]
        public IActionResult Edit(int id)
        {
            
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var thisCourse = Course.GetThisCourse(id);
            return View(thisCourse);
        }


    }
}