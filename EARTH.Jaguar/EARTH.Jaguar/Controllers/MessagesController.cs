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
        //public IEnumerable<PublicMessageModel> Get()
        //{
        //    try
        //    {
        //        using(Entities context = new Entities())
        //        {
        //            IEnumerable<PublicMessageModel> notas;

        //            notas = (from pm in context.P_NotasPublicas
        //                where pm.Activa == true
        //                select new PublicMessageModel{ Id= pm.idNotasPublicas, MessageDate= pm.FechaNota, Message= pm.Nota });
        //            return notas;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public IEnumerable<P_Notas> GetNewUserMessages(string userName, int last)
        {
            try
            {
                using (Entities context = new Entities())
                {
                    IEnumerable<P_Notas> messages = context.P_Notas.Where(n => n.usuario == userName && n.idNota > last);
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
