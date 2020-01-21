using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Burger2Home_ISL_Project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            LabelDescription.Visible = true;
            LabelDescription.Text = "MAGIC TOM BURGER";
            LabelPrice.Visible = true;
            LabelPrice.Text = "7.50 €";
        }
    }
}