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
    public class StudentsController : ControllerBase
    {
        private SchoolContext _db = new SchoolContext();

        // GET api/students
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return _db.Students.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
        }

        // PUT api/students/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            student.StudentId = id;
            _db.Entry(student).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/students/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var studentToDelete = _db.Students.FirstOrDefault(x => x.StudentId == id);
            _db.Students.Remove(studentToDelete);
            _db.SaveChanges();
        }
    }
}