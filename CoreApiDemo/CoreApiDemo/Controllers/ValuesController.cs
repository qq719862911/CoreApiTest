using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApiDemo.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //url:              http://localhost:6597/api/values
        //Content-Type :    application/json
        // body             1
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet(nameof(GetName)+ "/{id}")]
        public async Task<IActionResult> GetName(long id)
        {
            return Content("ddd"+ id);
        }

        [HttpGet(nameof(Login2)+"/{userName}/{password}")]
        public async Task<IActionResult> Login2(string userName,string password)
        {
            return Content(userName+password);
        }
        //url:              http://localhost:6597/api/values/Login3
        //Content-Type :    application/json
        // body             {"ID":"1","Name":"aaa","Phon":"13655554444"}
        [HttpPost(nameof(Login3))]
        public async Task<IActionResult> Login3([FromBody]Person person)
        {
            return Json(person);
        }

    }
}
