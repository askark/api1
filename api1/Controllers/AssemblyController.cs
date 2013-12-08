using api1.Network;
using BookSleeve;
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
            List<string> list = new List<string>();
            using (var conn = new RedisConnection("redis://rediscloud:8IoDSSPPCZPhodxK@pub-redis-18353.eu-west-1-1.2.ec2.garantiadata.com:18353"))
            {
                conn.Open();
                conn.Set(0, "crawler", "Crawler0");
                var value = conn.GetString(0, "crawler");
                string s = conn.Wait(value);
                list.Add(s);
            }
            Email.SendSimpleMessage();
            return list.AsEnumerable();
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
