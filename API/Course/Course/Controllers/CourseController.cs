using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Course.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        // GET: api/course
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/course/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/course
        [HttpPost]
        public void Post([FromBody] Models.Course course)
        {
        }

        // PUT api/course/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Models.Course course)
        {
        }

        // DELETE api/course/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
