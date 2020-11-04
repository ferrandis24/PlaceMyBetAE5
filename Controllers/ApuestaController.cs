using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ApuestaController : ApiController
    {
        // GET: api/Apuesta
        public IEnumerable<Apuesta> Retrieve(int apuestaid)
        {
            var repo = new ApuestaRepository();
            Apuesta apuesta = repo.Retrieve(apuestaid);
            yield return apuesta;
        }

        // POST: api/Apuesta
        public void Post([FromBody]ApuestaDTO apuesta)
        {
           
        }

        // PUT: api/Apuesta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuesta/5
        public void Delete(int id)
        {
        }
    }
}
