using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EARTH.Jaguar.Models;
using System.DirectoryServices;
using System.Web.Security;

namespace EARTH.Jaguar.Controllers
{
    public class LoginController : ApiController
    {
        public bool Post(LogOnModel model)
        {
            if (this.ValidateUser(model))
            {
                FormsAuthentication.SetAuthCookie(model.UserName,true);
                return true;
            }
            return false;
        }

        private bool ValidateUser(LogOnModel model)
        {
            bool valid = false;
            try
            {
                using (Entities context = new Entities())
                {
                    valid = context.P_Personas.Count(p => p.usuario == model.UserName) > 0;
                    if (valid)
                    {
                        DirectoryEntry entry = new DirectoryEntry("LDAP://" + "earth.ac.cr", model.UserName, model.Password);
                        //TODO: uncomment this line.
                        //object nativeObject = entry.NativeObject;
                    }
                }
                return valid;
            }
            catch (DirectoryServicesCOMException)
            {               
                return false;
            }
            catch (Exception)
            {                
                return false;
            }            
        }
    }
}
