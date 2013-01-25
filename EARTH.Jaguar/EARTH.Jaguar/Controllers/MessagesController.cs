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
        // GET api/user/{userName}/messages/{last}
        public IEnumerable<P_Notas> GetNewUserMessages(string userName, int last)
        {
            try
            {
                IEnumerable<P_Notas> messages;
                Entities context = new Entities();
                context.Configuration.ProxyCreationEnabled = false;
                messages = (from m in context.P_Notas
                            where m.usuario == userName && m.idNota > last
                            select m);
                return messages;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET api/user/{userName}/old_messages/{last}
        public IEnumerable<P_Notas> GetOldUserMessages(string userName, int last)
        {
            try
            {
                IEnumerable<P_Notas> messages;
                Entities context = new Entities();
                context.Configuration.ProxyCreationEnabled = false;
                messages = (from m in context.P_Notas
                            where m.usuario == userName && m.idNota <= last
                            select m).Take(10);
                return messages;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
