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
using EARTH.Jaguar.Models;

namespace EARTH.Jaguar.Controllers
{
    public class GradesController : ApiController
    {
        private Entities db = new Entities();

        // GET api/Grades
        public IEnumerable<R_RegistroNotas> GetR_RegistroNotas()
        {
            var r_registronotas = db.R_RegistroNotas.Include(r => r.R_Estudiantes);
            return r_registronotas.AsEnumerable();
        }

        // GET api/Grades/5
        public R_RegistroNotas GetR_RegistroNotas(int id)
        {
            R_RegistroNotas r_registronotas = db.R_RegistroNotas.Find(id);
            if (r_registronotas == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return r_registronotas;
        }

        // GET api/user/ealpizar/year/2013/period/001/Grades
        public IEnumerable<R_RegistroNotas> GetGrades(string userName, int year, string period)
        {
            db.Configuration.ProxyCreationEnabled = false;

            var grades = (from g in db.R_RegistroNotas.Include(g => g.R_Cursos)
                          join s in db.R_Estudiantes
                              on g.Estudiante equals s.IdPersona
                          where s.usuario == userName
                          && g.A_Adem == year
                          && g.Trimestre == period
                          select g);
                          
            return grades;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}