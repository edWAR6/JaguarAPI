using EARTH.Jaguar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EARTH.Jaguar.Controllers
{
    public class GradeController : ApiController
    {
        // GET api/user/{userName}/years
        public IEnumerable<VR_Rendimiento_A_Academ> Get(string userName)
        {
            try
            {
                IEnumerable<VR_Rendimiento_A_Academ> years;
                Entities context = new Entities();
                context.Configuration.ProxyCreationEnabled = false;
                years = (from y in context.VR_Rendimiento_A_Academ
                         join e in context.R_Estudiantes
                         on y.Estudiante equals e.IdPersona
                         where e.usuario == userName
                         select y);
                return years;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
