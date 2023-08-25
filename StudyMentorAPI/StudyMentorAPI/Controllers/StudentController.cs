using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using StudyMentorAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace StudyMentorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/Student
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "GetStudent")]
        public Student Get(int id)
        {
            Student student = new Student();
            student.IdStudent = id;
            student.NameStudent = "Student: " + id.ToString();
            student.Career = "Career" + id.ToString();
            student.University="University "+id.ToString();
            student.Cycle= 8;
            student.Headquarter="Headquarter "+id.ToString();
            student.Courses="Courses "+id.ToString();
        }

        // POST: api/Student
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
