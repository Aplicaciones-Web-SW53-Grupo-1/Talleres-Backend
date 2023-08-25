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
        // GET: api/Advisor
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Advisor/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Advisor
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
