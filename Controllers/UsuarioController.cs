﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        public IEnumerable<Usuario> Get()
        {
            var repo = new UsuarioRepository();
            List<Usuario> user = repo.Retrieve();
            return user;
        }

        // GET: api/Usuario/5
       /* public Usuario Get(int id)
        {
          
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }*/
    }
}
