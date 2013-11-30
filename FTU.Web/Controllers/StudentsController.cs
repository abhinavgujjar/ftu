using FTU.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FTU.Web.Controllers
{
    public class StudentsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Student> Get()
        {
            return new List<Student>(){
                new Student { FirstName = "aaaa" },
                new Student { FirstName = "bbbb" },
                new Student { FirstName = "cccc" },
                new Student { FirstName = "dddd" }
            };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}