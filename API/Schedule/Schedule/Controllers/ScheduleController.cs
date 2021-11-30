using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Schedule.Controllers
{
    [Route("api/[controller]")]
    public class ScheduleController : Controller
    {
        // GET: api/schedule
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/schedule/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/schedule
        [HttpPost]
        public void Post([FromBody] Models.Schedule schedule)
        {
        }

        // PUT api/schedule/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Models.Schedule schedule)
        {
        }

        // DELETE api/schedule/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
