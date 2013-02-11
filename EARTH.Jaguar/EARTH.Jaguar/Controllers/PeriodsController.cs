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
    public class PeriodsController : ApiController
    {
        private Entities db = new Entities();

        // GET api/Periods
        public IEnumerable<VR_Rendimiento_Periodos> GetVR_Rendimiento_Periodos()
        {
            return db.VR_Rendimiento_Periodos.AsEnumerable();
        }

        // GET api/Periods/5
        public VR_Rendimiento_Periodos GetVR_Rendimiento_Periodos(int id)
        {
            VR_Rendimiento_Periodos vr_rendimiento_periodos = db.VR_Rendimiento_Periodos.Find(id);
            if (vr_rendimiento_periodos == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return vr_rendimiento_periodos;
        }

        // GET api/user/ealpizar/year/2013/Periods
        public IEnumerable<VR_Rendimiento_Periodos> GetPeriodsByYearAndUser(string userName, int year)
        {
            var periods = (from p in db.VR_Rendimiento_Periodos
                           join e in db.R_Estudiantes
                           on p.Estudiante equals e.IdPersona
                           where e.usuario == userName
                           && p.A_Adem == year
                           select p
            );
            return periods;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}