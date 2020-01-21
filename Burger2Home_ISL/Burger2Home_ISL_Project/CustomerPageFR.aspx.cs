using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Burger2Home_ISL_Project.Views
{
    public partial class CustomerPageFR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["customer"] != null)
            {
                LabelConnectedCustomer.Text = " Bienvenu(e) :" + Session["customer"].ToString();
            }
            Btn_Profil.Text = "ok ok";
        }
        protected void Btn_retour_Click(object sender, EventArgs e)
        {
           // Response.Redirect("Default.aspx");
        }
    }
}