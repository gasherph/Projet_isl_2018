using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Burger2Home_ISL_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = DateTime.Now.ToString("dddd d MMMM yyyy");// Affiche par exemple:Vendredi 15 février 2019
            //Label1.Text = DateTime.Now.ToString(" d MMMM yyyy");// Affiche par exemple:15 février 2019
            //Header.Visible = false;
            //HtmlGenericControl customers   = (HtmlGenericControl)Master?.FindControl("customers");
            HtmlGenericControl allCustomers= (HtmlGenericControl)Master?.FindControl("allCustomers");
            HtmlGenericControl categories  = (HtmlGenericControl)Master?.FindControl("categories");
            HtmlGenericControl ingredients = (HtmlGenericControl)Master?.FindControl("ingredients");
            HtmlGenericControl burgers     = (HtmlGenericControl)Master?.FindControl("burgers");
            HtmlGenericControl orders      = (HtmlGenericControl)Master?.FindControl("orders");
            HtmlGenericControl users       = (HtmlGenericControl)Master?.FindControl("Users");
            HtmlGenericControl newUser     = (HtmlGenericControl)Master?.FindControl("newUser");
            Button user = (Button)Master?.FindControl("BtnUser");
            Button login= (Button)Master?.FindControl("BtnConnexion");


            //customers.Visible = false;
            allCustomers.Visible = false;
            categories.Visible = false;
            ingredients.Visible = false;
            burgers.Visible = false;
            orders.Visible = false;
            newUser.Visible = false;
            users.Visible = false;
            user.Visible = false;
            login.Visible = false;

        }

        protected void Btn_Connexion_Click(object sender, EventArgs e)
        {
           Server.Transfer("~/toConnect.aspx");
            //Response.Redirect("~/toConnect.aspx");
        }
    }
}