using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Burger2Home_ISL_Project
{
    public partial class CustomersView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayData();
            }
        }
        protected void DisplayData()
        {
            DataTable dt = new DataTable();
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Burger2HomeConnectionString"].ConnectionString);
            SqlConnection conn = new SqlConnection("Data Source = EPHREM-PC; Initial Catalog = Burger2Home; Integrated Security = True;  MultipleActiveResultSets = True; Application Name = EntityFramework");
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer",conn);
            conn.Open();
            string query = "SELECT * FROM Customer";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //conn.Open();
            sda.Fill(dt);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            conn.Close();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            TextCustomerID.Text = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text;
            TextFirstname.Text = GridView1.Rows[e.NewSelectedIndex].Cells[2].Text;
            Textlastname.Text = GridView1.Rows[e.NewSelectedIndex].Cells[3].Text;
            TextEmail.Text = GridView1.Rows[e.NewSelectedIndex].Cells[4].Text;
            TextPassword.Text = GridView1.Rows[e.NewSelectedIndex].Cells[5].Text;
            TextAddress.Text = GridView1.Rows[e.NewSelectedIndex].Cells[4].Text;
        }
    }
}