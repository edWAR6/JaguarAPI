using EARTH.Jaguar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EARTH.Jaguar.Filters;

namespace EARTH.Jaguar.Controllers
{
    public class PublicMessagesController : ApiController
    {
        // GET api/public_messages/{last}
        [Authorize]
        [InitializeSimpleMembership]
        public IEnumerable<P_NotasPublicas> GetNewPublicMessages(int last)
        {
            try
            {
                Entities context = new Entities();
                context.Configuration.ProxyCreationEnabled = false;
                IEnumerable<P_NotasPublicas> notas;

                notas = (from pm in context.P_NotasPublicas
                         where pm.Activa == true && pm.idNotasPublicas > last
                         select pm).Take(50); ;
                return notas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET api/old_public_messages/{last}
        // [Authorize]
        [InitializeSimpleMembership]
        public IEnumerable<P_NotasPublicas> GetOldPublicMessages(int last)
        {
            try
            {
                Entities context = new Entities();
                context.Configuration.ProxyCreationEnabled = false;
                IEnumerable<P_NotasPublicas> notas;

                notas = (from pm in context.P_NotasPublicas
                         where pm.Activa == true && pm.idNotasPublicas <= last
                         select pm).Take(50); ;
                return notas;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}