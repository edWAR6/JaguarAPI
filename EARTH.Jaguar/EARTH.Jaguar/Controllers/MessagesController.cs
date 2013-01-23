using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EARTH.Jaguar.Models;

namespace EARTH.Jaguar.Controllers
{
    public class MessagesController : ApiController
    {
        // GET api/message
        public IEnumerable<string> Get()
        {
            try
            {
                using(Entities context = new Entities())
                {
                    IEnumerable<context.P_Me
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public IEnumerable<string> GetUserMessages(int id)
        {
            return new string[] { id + "message 1", id + "message 2" };
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
