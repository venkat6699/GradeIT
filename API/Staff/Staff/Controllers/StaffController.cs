using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Staff.Controllers
{
    [Route("api/[controller]")]
    public class StaffController : Controller
    {
        // GET: api/staff
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/staff/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/staff
        [HttpPost]
        public void Post([FromBody] Models.Staff staff)
        {
        }

        // PUT api/staff/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Models.Staff staff)
        {
        }

        // DELETE api/staff/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
