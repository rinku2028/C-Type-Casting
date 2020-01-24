using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace typecast1
{
    public class Global : System.Web.HttpApplication
    {
        public object RouteConfig { get; private set; }

        protected void Application_Start(object sender, EventArgs e)
        {
          /*  RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                new ScriptResourceDefinition
                {
                    Path = "/~Scripts/jquery-2.1.1.min.js"
                }
            );*/
        }
        public static void RegisterRoutes(RouteCollection routes)
        {
           /* var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);*/
        }
    }
}