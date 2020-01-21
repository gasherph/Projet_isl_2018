using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI.HtmlControls;


namespace Burger2Home_ISL_Project
{
    public partial class CustomerRegister : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlGenericControl customers = (HtmlGenericControl)Master?.FindControl("customers");
            HtmlGenericControl allCustomers = (HtmlGenericControl)Master?.FindControl("allCustomers");
            HtmlGenericControl categories = (HtmlGenericControl)Master?.FindControl("categories");
            HtmlGenericControl ingredients = (HtmlGenericControl)Master?.FindControl("ingredients");
            HtmlGenericControl burgers = (HtmlGenericControl)Master?.FindControl("burgers");
            HtmlGenericControl orders = (HtmlGenericControl)Master?.FindControl("orders");
            HtmlGenericControl users = (HtmlGenericControl)Master?.FindControl("Users");
            HtmlGenericControl newUser = (HtmlGenericControl)Master?.FindControl("newUser");
            Button user = (Button)Master?.FindControl("BtnUser");


            customers.Visible = false;
            allCustomers.Visible = false;
            categories.Visible = false;
            ingredients.Visible = false;
            burgers.Visible = false;
            orders.Visible = false;
            newUser.Visible = false;
            users.Visible = false;
            user.Visible = false;

        }
        protected void Btn_cancel_Click(object sender, EventArgs e)
        {
            TextBox_firstname.Text = TextBox_lastname.Text = TextBox_email.Text = TextBox_address.Text = TextBox_password.Text = " ";
            Btn_cancel_Click(sender, e); //Retourner le focus!
        }
        protected void Btn_Save_Click(object sender, EventArgs e)
        {

            //Insert Logic  

            //SqlConnection conn = new SqlConnection("Data Source = MONPC-PC; Initial Catalog = Burger2Home; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
            SqlConnection conn = new SqlConnection("Data Source = EPHREM-PC; Initial Catalog = Burger2Home; Integrated Security = True");
            conn.Open();
            var requete = " ";
            int ok = 1;

            if (!(TextBox_email.Text.Equals(TextBox_Confirm_Email.Text)))
            {
                ok = 0;
                Label_Email_Distinct.Visible = true;
                TextBox_Confirm_Email.Focus();
            }
            else
            {

                if (!(TextBox_password.Text.Equals(TextBox_Password_Confirm.Text)))
                {
                    ok = 0;
                    Label_Password_Distinct.Visible = true;
                    TextBox_Password_Confirm.Focus();
                }
                else
                {
                    if (TextBox_email.Text.Equals(""))
                    {
                        ok = 0;
                        Label_mail_exist.Text = "Ce champs ne doit pas être vide!";
                        Label_mail_exist.Focus();

                    }
                    else
                    {
                        if (TextBox_password.Text.Equals(""))
                        {
                            ok = 0;
                            Label_password_vide.Visible = true;
                            TextBox_password.Focus();

                        }
                    }

                }
            }

            if (IfEmailExist(conn, TextBox_email.Text))
            {

                ok = 0;
                Label_mail_exist.Visible = true;
                TextBox_email.Focus();
            }

            if (ok == 1)
            {
                //string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox_password.Text, "SHA1");
                //requete = @"INSERT INTO[dbo].[Customer] ([firstname],[lastname],[email],[password],[address]) VALUES('" + TextBox_firstname.Text + "', '" + TextBox_lastname.Text + "', '" + TextBox_email.Text + "','" + EncryptedPassword + "','" + TextBox_address.Text + "')";
                requete = @"INSERT INTO[dbo].[Customer] ([firstname],[lastname],[email],[password],[address]) VALUES('" + TextBox_firstname.Text + "', '" + TextBox_lastname.Text + "', '" + TextBox_email.Text + "','" + TextBox_password.Text + "','" + TextBox_address.Text + "')";
            }
            int insert = ok;
            
            SqlCommand cmd = new SqlCommand(requete, conn);
            cmd.ExecuteNonQuery();          
            Session["newCustomer"] = TextBox_firstname.Text + " " + TextBox_lastname.Text;
            conn.Close();
            Response.Redirect("toConnect.aspx");

        }
        private bool IfEmailExist(SqlConnection conn, string email)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM Customer WHERE [email] ='" + email + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                sda = new SqlDataAdapter("SELECT 1 FROM Users WHERE [email] ='" + email + "'", conn);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}