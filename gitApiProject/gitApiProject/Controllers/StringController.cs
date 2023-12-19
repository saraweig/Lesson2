using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gitApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        // GET: api/<StringController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<StringController>
        [HttpPost]
        public List<string> Post(string value)
        {
            MyStrings.s.Add(value);
            return MyStrings.s;
        }
    }
}

