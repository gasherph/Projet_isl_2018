using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Burger2Home_ISL_Project
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["customer"] != null)
            {
                HtmlGenericControl customers = (HtmlGenericControl)Master?.FindControl("customers");
                HtmlGenericControl allCustomers = (HtmlGenericControl)Master?.FindControl("allCustomers");
                HtmlGenericControl categories = (HtmlGenericControl)Master?.FindControl("categories");

                Button user = (Button)Master?.FindControl("BtnUser");
                Button connected = (Button)Master?.FindControl("BtnConnexion");
                if (customers != null)
                {
                    customers.Visible = false;
                    allCustomers.Visible = false;
                    categories.Visible = false;
                    user.Text = Session["customer"].ToString();
                }

                else
                {
                    //if((bool)Session["isAdmin"] == true)// Je suis un super Admin
                    //{
                    //    allCustomers.Visible = true;
                    //    customers.Visible = false;
                    //}
                    /************************************/
                    //customers.Visible = true;
                    //customers.Visible = false;
                    allCustomers.Visible = true;
                    categories.Visible = true;
                    //user.Text = Session["Name"].ToString();
                }
                
            }
            else
            {
                Button user = (Button)Master?.FindControl("BtnUser");
                user.Text = Session["Name"].ToString();
            }       
        }
    }
}