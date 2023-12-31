﻿using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gitApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        // GET: api/<StringController>
        [HttpGet]
        public List<string> Get()
        {
            return MyStrings.s;
        }
        // DELETE api/<StringController>/5
        [HttpDelete("{str}")]
        public List<string> Delete(string str)
        {

            MyStrings.s.Remove(MyStrings.s.FirstOrDefault(st => st == str));
            return MyStrings.s;
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

