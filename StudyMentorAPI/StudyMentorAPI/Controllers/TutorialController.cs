using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyMentorAPI.Model;

namespace StudyMentorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        // GET: api/Tutorial
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tutorial/5
        [HttpGet("{id}", Name = "GetTutorial")]
        public Tutorial Get(int id)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Id = id;
            tutorial.Name = "Tutorial: " + id.ToString();
            tutorial.Count = 10;

            return tutorial;
        }

        // POST: api/Tutorial
        [HttpPost]
        public StatusCodeResult Post([FromBody] Tutorial tutorial)
        {
            try
            {
                if (tutorial.Name == "")
                    return StatusCode(400);

                if (tutorial.Name == "Tutorial") throw new Exception("unexpected error");
                
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                //Logear el error = almacenar 8800, file, cloud
                return StatusCode(500);
            }
        }

        // PUT: api/Tutorial/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
