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
    public class YearsController : ApiController
    {
        private Entities db = new Entities();

        // GET api/Years
        public IEnumerable<VR_Rendimiento_A_Academ> GetVR_Rendimiento_A_Academ()
        {
            return db.VR_Rendimiento_A_Academ.AsEnumerable();
        }

        // GET api/user/{userName}/years
        public IEnumerable<VR_Rendimiento_A_Academ> GetYearsByUser(string userName)
        {
            var years = (from y in db.VR_Rendimiento_A_Academ
                         join e in db.R_Estudiantes
                         on y.Estudiante equals e.IdPersona
                         orderby y.A_Adem
                         where e.usuario == userName
                         select y
            );
            return years;
        }

        // GET api/Years/5
        public VR_Rendimiento_A_Academ GetVR_Rendimiento_A_Academ(int id)
        {
            VR_Rendimiento_A_Academ vr_rendimiento_a_academ = db.VR_Rendimiento_A_Academ.Find(id);
            if (vr_rendimiento_a_academ == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return vr_rendimiento_a_academ;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}