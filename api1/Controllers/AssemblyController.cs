using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api1.Controllers
{
    public class AssemblyController : ApiController
    {
        // GET 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/assembly/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/assembly
        public void Post([FromBody]string value)
        {
        }

        // PUT api/assembly/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/assembly/5
        public void Delete(int id)
        {
        }
    }
}
