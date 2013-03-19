using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EARTH.Jaguar.Models;
using System.DirectoryServices;
using System.Web.Security;
using System.Web.Script.Services;
using System.Diagnostics;

namespace EARTH.Jaguar.Controllers
{
    [AllowAnonymous]
    public class LoginController : ApiController
    {
        //POST api/login
        [AllowAnonymous]
        
        public HttpResponseMessage Post(LogOnModel model)
        {
            try 
	        {	        
                if (this.ValidateUser(model))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName,true);
                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
                return Request.CreateResponse(HttpStatusCode.OK, false);
            }
            catch (DirectoryServicesCOMException dse)
            {
                HttpError error = new HttpError(dse.Message.Replace("\n", " ").Replace("\r", " ").Replace("\t", " "));
                return Request.CreateResponse(HttpStatusCode.Unauthorized, error);
            }
            catch (Exception ex)
            {
                HttpError error = new HttpError(ex.Message.Replace("\n", " ").Replace("\r", " ").Replace("\t", " "));
                EventLog log = new EventLog();
                log.Source = "Jaguar_Mobile";
                log.WriteEntry(ex.Message);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, error);
            }
        }

        private bool ValidateUser(LogOnModel model)
        {
            bool valid = false;
            using (Entities context = new Entities())
            {
                valid = context.P_Personas.Count(p => p.usuario == model.UserName) > 0;
                if (valid)
                {
                    DirectoryEntry entry = new DirectoryEntry("LDAP://" + "earth.ac.cr", model.UserName, model.Password);
                    //TODO: uncomment this line in server.
                    object nativeObject = entry.NativeObject;
                }
            }
            return valid;                        
        }
    }
}
