using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using EARTH.Jaguar.Filters;
using EARTH.Jaguar.Models;

namespace EARTH.Jaguar.Controllers
{
    public class PersonalMessagesController : ApiController
    {
        private Entities db = new Entities();

        // GET api/PersonalMessages
        [Authorize]
        [InitializeSimpleMembership]
        public IEnumerable<P_Notas> GetP_Notas()
        {
            var p_notas = db.P_Notas.Include(p => p.P_Personas);
            return p_notas.AsEnumerable();
        }

        // GET api/PersonalMessages/5
        [Authorize]
        [InitializeSimpleMembership]
        public P_Notas GetP_Notas(int id)
        {
            P_Notas p_notas = db.P_Notas.Find(id);
            if (p_notas == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return p_notas;
        }

        // PUT api/PersonalMessages/5
        [Authorize]
        [InitializeSimpleMembership]
        public HttpResponseMessage PutP_Notas(int id, P_Notas p_notas)
        {
            if (ModelState.IsValid && id == p_notas.IdPersona)
            {
                db.Entry(p_notas).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/PersonalMessages
        [Authorize]
        [InitializeSimpleMembership]
        public HttpResponseMessage PostP_Notas(P_Notas p_notas)
        {
            if (ModelState.IsValid)
            {
                db.P_Notas.Add(p_notas);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, p_notas);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = p_notas.IdPersona }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/PersonalMessages/5
        [Authorize]
        [InitializeSimpleMembership]
        public HttpResponseMessage DeleteP_Notas(int id)
        {
            P_Notas p_notas = db.P_Notas.Find(id);
            if (p_notas == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.P_Notas.Remove(p_notas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, p_notas);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}