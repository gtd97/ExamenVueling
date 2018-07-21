using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExamenVueling.Facade.Api.Controllers
{
    public class PoliciesController : ApiController
    {
        // GET: api/Policies
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Policies/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Policies
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Policies/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Policies/5
        public void Delete(int id)
        {
        }
    }
}
