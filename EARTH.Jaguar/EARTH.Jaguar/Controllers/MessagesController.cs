using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EARTH.Jaguar.Models;
using System.Collections;

namespace EARTH.Jaguar.Controllers
{
    public class MessagesController : ApiController
    {
        // GET api/message
        public IQueryable<P_NotasPublicas> Get()
        {
            try
            {
                using(Entities context = new Entities())
                {
                    IQueryable<P_NotasPublicas> notas;
                    notas = context.P_NotasPublicas.Where(n => n.Activa == true);
                    return notas;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<P_Notas> GetUserMessages(string userName)
        {
            try
            {
                using (Entities context = new Entities())
                {
                    IEnumerable<P_Notas> messages = context.P_Notas.Where(n => n.Activa == true && n.usuario == userName);
                    return messages;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //// GET api/message/id
        //public string Get(int id)
        //{
        //    return "value " + id;
        //}

        //// POST api/default1
        //public void Post(string value)
        //{
        
        //}

        //// PUT api/default1/5
        //public void Put(int id, string value)
        //{

        //}

        //// DELETE api/default1/5
        //public void Delete(int id)
        //{

        //}
    }
}
