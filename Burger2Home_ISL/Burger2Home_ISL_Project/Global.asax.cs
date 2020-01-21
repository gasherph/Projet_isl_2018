using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Web.SessionState;
using System.Net.Mail;
using System.Diagnostics;
using System.Text;
using System.Configuration;
using System.Web.Security;

namespace Burger2Home_ISL_Project
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        // Code that runs on application startup
        protected void Application_Start()
        {
            //GlobalConfiguration.Configure(WebApiConfig.Register);
             Database.SetInitializer<Models.Burger2Home>(null);
            //Database.SetInitializer<Models.Burger2Home>(new DropCreateDatabaseIfModelChanges<Models.Burger2Home>());
        }
        void Application_End(object sender, EventArgs e)
        {
            // Code that runs on application shutdown
        }
        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            Exception ex = Server.GetLastError();
            if(ex != null)
            {
                //Logger.Log(ex);
                Server.ClearError();
                Server.Transfer("~/Errors.aspx");
            }
        }
    }
}