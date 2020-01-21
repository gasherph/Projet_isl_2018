using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using Facebook;

namespace Burger2Home_ISL_Project
{
    public partial class Post_on_Facebook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckAutorization();

        }
        private void CheckAutorization()
        {
            string appID = "447994412411310";
            string appSecret = "918fff2c4753781ccdaef1a0ea0eda0f";
            string scope = "publish_stream,manage_page";

            if (Request["code" ] == null)
            {
                Response.Redirect(string.Format("https://www.facebook.com/connect/login_success.html?client_id={0}&redirect_uri={1}&scope={2}", appID, Request.Url.AbsoluteUri,scope));
                //Response.Redirect(string.Format("https://graph.facebook.com/oauth/authorize?client_id={0}&redirect_uri={1}&scope={2}", appID, Request.Url.AbsoluteUri, scope));
            }
            else
            {
                Dictionary<string, string> tokens = new Dictionary<string, string>();
                string url = string.Format("https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&scope={2}&code={3}&client_secret={4}", appID, Request.Url.AbsoluteUri,scope,Request["code"].ToString(),appSecret);            
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;              
                using ( HttpWebResponse response = request.GetResponse() as HttpWebResponse )
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    //StreamReader reader = new StreamReader(response.GetRequestStream());
                    string vals = reader.ReadToEnd();
                    foreach(string token in vals.Split('&'))
                    {
                       // meh.aspx? token1= steve&token2=jake&...
                        tokens.Add(token.Substring(0, token.IndexOf("=")),
                        token.Substring(token.IndexOf("=") + 1, token.Length - token.IndexOf("=") - 1));
                    }
                }
                string access_token = tokens["access_token"];
                var fbClient = new FacebookClient(access_token);
                fbClient.Post("/me/feed", new { message = "Ephrem be cool!!" });
            }
        }
    }
}