using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;
using Facebook;


namespace Burger2Home_ISL_Project
{
    public partial class Login_facebook : System.Web.UI.Page
    {
        //public string AppID = "447994412411310";// App id
        //public string AppSECRET = "918fff2c4753781ccdaef1a0ea0eda0f";//App secret
        //private Uri _loginUrl;
        //private Uri _logoutUrl;
        //FacebookClient fbClient = new FacebookClient();
        //private const string _ExtendedPermissions = "user_about_me,publish_stream,offline_access";

        //private const string _ExtendedPermissions = "user_about_me,publish_stream,offline_access";
        //private const string _ExtendedPermissions = "email,public_profile,offline_access";
        //private const string _ExtendedPermissions = "default,email,public_profile";       
        //private const string _ExtendedPermissions = "email,publish_stream,offline_access";
        private const string _ExtendedPermissions = "email,public_profile";

        protected void Page_Load(object sender, EventArgs e)
        {
            Login();          

        }       
        public static string PublicClientId { get; private set; }

        public void Login()
        {
            //dynamic parameters = new ExpandoObject();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["response_type"] = "token";//la valeur Token car on a besoin d'accès
            parameters["display"] = "popup";//La valeur Touch est addapté pour les appli Mobile

            //la valeur Scope corresponds aux infos qu'on veut obtenir de la prt de l'utilisateur

            //parameters["scope"] = "user_about_me, friends_about_me, user_birthday, friends_birthday, publish_stream";

            parameters["scope"] = "email";
            parameters["redirect_uri"] = "https://www.facebook.com/connect/login_success.html";
            parameters["client_id"] = "447994412411310";
            parameters["client_secret"] = "918fff2c4753781ccdaef1a0ea0eda0f";

            //parameters.client_id = AppID;
            //parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";
            //parameters.response_type = "token";
            //parameters.display = "popup";

            if (!string.IsNullOrWhiteSpace(_ExtendedPermissions))
            {
                //parameters.scope = _ExtendedPermissions;
                parameters["scope"] = _ExtendedPermissions;
            }
            FacebookClient client = new FacebookClient();
            Uri uri = client.GetLoginUrl(parameters);
            Response.Redirect(uri.AbsoluteUri);

        }

    }
}