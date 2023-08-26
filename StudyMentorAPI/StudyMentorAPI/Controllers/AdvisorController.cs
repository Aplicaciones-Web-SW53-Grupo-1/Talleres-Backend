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
    public class AdvisorController : ControllerBase
    {
        
        private static List<Advisor> advisors = new List<Advisor>
        {
            new Advisor { IdAdvisor = 1, NameAdvisor = "Jose Torres", Area = "Math", Email = "josetorres@gmail.com", 
                Phone = "465213789", Curriculum = "https://www.linkedin.com/in/josetorres/"},
            new Advisor { IdAdvisor = 2, NameAdvisor = "Juan Perez", Area = "Programming", Email = "juanperez@gmail.com",
                Phone = "454812345", Curriculum = "https://www.linkedin.com/in/juanperez/" },
        };
        
        // GET: api/Advisor
        [HttpGet]
        public IEnumerable<Advisor> Get()
        {
            return advisors;
        }

        // GET: api/Advisor/5
        [HttpGet("{id}", Name = "GetAdvisor")]
        public ActionResult<Advisor> Get(int id)
        {
            var advisor = advisors.FirstOrDefault(a => a.IdAdvisor == id);
            if (advisor == null)
            {
                return NotFound(); // Devolver 404 si no se encuentra el asesor
            }
            return advisor;
        }

        // POST: api/Advisor
        [HttpPost]
        
            public StatusCodeResult Post([FromBody] Advisor advisor)
            {
                try
                {
                    if (advisor.NameAdvisor == "")
                        return StatusCode(400);
                    if (advisor.NameAdvisor == "Admin") throw new Exception("You can´t use this name");
                    
                    return StatusCode(201);
                    
                }
                catch (Exception ex)
                {
                    return StatusCode(500);
                }
            }

        // PUT: api/Advisor/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Advisor/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
