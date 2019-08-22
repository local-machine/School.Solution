using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private SchoolContext _db = new SchoolContext();

        // GET api/courses
        [HttpGet]
        public ActionResult<IEnumerable<Course>> Get()
        {
            return _db.Courses.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] Course course)
        {
            _db.Courses.Add(course);
            _db.SaveChanges();
        }

        // PUT api/courses/5
        public void Put(int id, [FromBody] Course course)
        {
            course.CourseId = id;
            _db.Entry(course).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/courses/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var courseToDelete = _db.Courses.FirstOrDefault(x => x.CourseId == id);
            _db.Courses.Remove(courseToDelete);
            _db.SaveChanges();
        }
    }
}