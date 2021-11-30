using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Controllers
{
    [Route("api/[controller]")]
    public class SchoolController : Controller
    {
        // GET: api/school
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/school/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/school
        [HttpPost]
        public void Post([FromBody] Models.School school)
        {
        }

        // PUT api/school/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Models.School school)
        {
        }

        // DELETE api/school/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
