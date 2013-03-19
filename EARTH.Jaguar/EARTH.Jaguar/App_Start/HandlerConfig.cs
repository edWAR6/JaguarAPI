using EARTH.Jaguar.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace EARTH.Jaguar
{
    public class HandlerConfig
    {
        public static void RegisterHandlers(Collection<DelegatingHandler> handlers)
        {
            //handlers.Add(new CorsMessageHandler());
            //handlers.Add(new ClientErrorHandler());
        }
    }
}