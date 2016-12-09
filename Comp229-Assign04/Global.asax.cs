﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Comp229_Assign04
{
    public class Global : HttpApplication
    {
        public static List<models.BaseStats> models;
        void Application_Start(object sender, EventArgs e)
        {
         
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            populatelist();

        }

        private void populatelist()
        {

            using (StreamReader reader = new StreamReader(Server.MapPath("~/Assign04.json")))
            {

                models = JsonConvert.DeserializeObject<List<models.BaseStats>>(reader.ReadToEnd());

            }

        }
    }
}