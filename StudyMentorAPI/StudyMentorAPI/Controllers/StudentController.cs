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
        private static List<Student> students = new List<Student> { };
        // GET: api/Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "GetStudent")]
        public Student Get(int id)
        {
            Student student = new Student();
            student.IdStudent = id;
            student.NameStudent = "Student: " + id.ToString();
            student.Career = "Career " + id.ToString();
            student.University="University "+id.ToString();
            student.Cycle= 8;
            student.Headquarter="Headquarter "+id.ToString();
            student.Courses="Courses "+id.ToString();
            return student;
        }

        // POST: api/Student
        [HttpPost]
        public StatusCodeResult Post([FromBody] Student student)
        {
            try
            {
                switch (student.NameStudent)
                {
                    case "no student":
                        return StatusCode(400);
                    case "Exception 500":
                        throw new Exception("expected error forced by name");
                    default:
                        students.Add(student);
                        return StatusCode(201);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

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
