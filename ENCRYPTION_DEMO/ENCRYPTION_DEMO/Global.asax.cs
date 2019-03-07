﻿using SERVER_SIDE_RSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ENCRYPTION_DEMO
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            CORE_MODULE.Initialize(4096);

        }
    }
}
