using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Burger2Home_ISL_Project
{
    public partial class Customers : System.Web.UI.Page
    {
        //SqlConnection conn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=Burger2Home;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        SqlConnection conn = new SqlConnection("Data Source = EPHREM-PC; Initial Catalog = Burger2Home; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }

        }
        protected void BindData()
        {
            DataSet ds = new DataSet();
            DataTable FromTable = new DataTable();
            conn.Open();
            string query = "SELECT * FROM Customer";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            FromTable = ds.Tables[0];
            if (FromTable.Rows.Count > 0)
            {
                GridViewCustomerDetails.DataSource = FromTable;
                GridViewCustomerDetails.DataBind();
            }
            else
            {
                FromTable.Rows.Add(FromTable.NewRow());
                GridViewCustomerDetails.DataSource = FromTable;
                GridViewCustomerDetails.DataBind();
                int TotalColumns = GridViewCustomerDetails.Rows[0].Cells.Count;
                GridViewCustomerDetails.Rows[0].Cells.Clear();
                GridViewCustomerDetails.Rows[0].Cells.Add(new TableCell());
                GridViewCustomerDetails.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                GridViewCustomerDetails.Rows[0].Cells[0].Text = "No records Found";
            }

            ds.Dispose();
            conn.Close();
        }

        protected void GridViewCustomerDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblCutomerID = (Label)GridViewCustomerDetails.Rows[e.RowIndex].FindControl("lblCutomerID");
            conn.Open();
            string query = "DELETE FROM Customer WHERE customer_id=@customer_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@customer_id", lblCutomerID.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            BindData();
        }
        protected void GridViewCustomerDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("ADD"))
            {
                TextBox txtAddCutomerID = (TextBox)GridViewCustomerDetails.FooterRow.FindControl("txtAddCutomerID");
                TextBox txtAddFirstName = (TextBox)GridViewCustomerDetails.FooterRow.FindControl("txtAddFirstName");
                TextBox txtAddLastName = (TextBox)GridViewCustomerDetails.FooterRow.FindControl("txtAddLastName");
                TextBox txtAddEmail = (TextBox)GridViewCustomerDetails.FooterRow.FindControl("txtAddEmail");
                TextBox txtAddPassword = (TextBox)GridViewCustomerDetails.FooterRow.FindControl("txtAddPassword");
                TextBox txtAddAddress = (TextBox)GridViewCustomerDetails.FooterRow.FindControl("txtAddAddress");
                conn.Open();

                //string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox_password.Text, "SHA1");
                string query = @"INSERT INTO[dbo].[Customer] ([firstname],[lastname],[email],[password],[address]) VALUES('" + txtAddFirstName.Text + "', '" + txtAddLastName.Text + "', '" + txtAddEmail.Text + "','" + txtAddPassword.Text + "','" + txtAddAddress.Text + "')";

                //string query = "INSERT INTO Customer(firstname,lastname,email,password,address) values(@firstname,@lastname,@email,@password,@address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@customer_id", txtAddCutomerID.Text);
                //cmd.Parameters.AddWithValue("@firstname", txtAddFirstName.Text);
                //cmd.Parameters.AddWithValue("@lastname", txtAddLastName.Text);
                //cmd.Parameters.AddWithValue("@email", txtAddEmail.Text);
                //cmd.Parameters.AddWithValue("@password", txtAddPassword.Text);
                //cmd.Parameters.AddWithValue("@address", txtAddAddress.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindData();

            }

        }
        protected void GridViewCustomerDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblEditCutomerID = (Label)GridViewCustomerDetails.Rows[e.RowIndex].FindControl("lblEditCutomerID");
            TextBox txtEditFirstName = (TextBox)GridViewCustomerDetails.Rows[e.RowIndex].FindControl("txtEditFirstName");
            TextBox txtEditLastName = (TextBox)GridViewCustomerDetails.Rows[e.RowIndex].FindControl("txtEditLastName");
            TextBox txtEditEmail = (TextBox)GridViewCustomerDetails.Rows[e.RowIndex].FindControl("txtEditEmail");
            TextBox txtEditPassword = (TextBox)GridViewCustomerDetails.Rows[e.RowIndex].FindControl("txtEditPassword");
            TextBox txtEditAddress = (TextBox)GridViewCustomerDetails.Rows[e.RowIndex].FindControl("txtEditAddress");
            conn.Open();
            string query = @"UPDATE [dbo].[Customer] SET [firstname]=@firstname,[lastname]=@lastname,[email]=@email,[password]=@password,[address]=@address WHERE [customer_id]=@customer_id";           
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@customer_id", lblEditCutomerID.Text);
            cmd.Parameters.AddWithValue("@firstname", txtEditFirstName.Text);
            cmd.Parameters.AddWithValue("@lastname", txtEditLastName.Text);
            cmd.Parameters.AddWithValue("@email", txtEditEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtEditPassword.Text);
            cmd.Parameters.AddWithValue("@address", txtEditAddress.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            GridViewCustomerDetails.EditIndex = -1;
            BindData();

        }
        protected void GridViewCustomerDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewCustomerDetails.EditIndex = -1;
            BindData();
        }
        protected void GridViewCustomerDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewCustomerDetails.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void GridViewCustomerDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}