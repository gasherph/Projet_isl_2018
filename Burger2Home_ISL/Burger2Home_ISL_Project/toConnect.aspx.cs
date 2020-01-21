using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Dapper;
using System.Web.Security;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;

namespace Burger2Home_ISL_Project
{
    public partial class toConnect : System.Web.UI.Page
    {

        Models.Users user;
        Models.Customer customer;

        protected void Page_Load(object sender, EventArgs e)
        {
            //HtmlGenericControl customers = (HtmlGenericControl)Master?.FindControl("customers");
            HtmlGenericControl allCustomers = (HtmlGenericControl)Master?.FindControl("allCustomers");
            HtmlGenericControl categories = (HtmlGenericControl)Master?.FindControl("categories");
            HtmlGenericControl ingredients = (HtmlGenericControl)Master?.FindControl("ingredients");
            HtmlGenericControl burgers = (HtmlGenericControl)Master?.FindControl("burgers");
            HtmlGenericControl orders = (HtmlGenericControl)Master?.FindControl("orders");
            HtmlGenericControl users = (HtmlGenericControl)Master?.FindControl("Users");
            HtmlGenericControl newUser = (HtmlGenericControl)Master?.FindControl("newUser");
            Button user = (Button)Master?.FindControl("BtnUser");
            Button login = (Button)Master?.FindControl("BtnConnexion");

            //customers.Visible = false;
            allCustomers.Visible = false;
            categories.Visible = false;
            ingredients.Visible = false;
            burgers.Visible = false;
            orders.Visible = false;
            users.Visible = false;
            newUser.Visible = false;
            user.Visible = false;
            login.Visible = false;
            if (Session["newCustomer"] != null)
            {
                LblNewCustomer.Visible = true;
                LblNewCustomer.Text = "Welcome: " + Session["newCustomer"].ToString()+ " you are succefully registered! You can Login now!";
                
            }


        }

        protected void Btn_Send_Click(object sender, EventArgs e)
        {
            //string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBoxPassword.Text, "SHA1");
            //SqlConnection conn = new SqlConnection("Data Source = PC\\SQLEXPRESS; Initial Catalog = Burger2Home; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
            SqlConnection conn = new SqlConnection("Data Source = EPHREM-PC; Initial Catalog = Burger2Home; Integrated Security = True;  MultipleActiveResultSets = True; Application Name = EntityFramework");
            var query = "";
            conn.Open();
            //query = @"SELECT* FROM Customer WHERE email = '" + TextBoxEmail.Text + "'AND password = '" + EncryptedPassword + "'";
            query = @"SELECT* FROM Customer WHERE email = '" + TextBoxEmail.Text + "'AND password = '" + TextBoxPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();          
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                customer = new Models.Customer();
                customer.firstname = reader.GetString(1);
                customer.lastname = reader.GetString(2);
                customer.email = reader.GetString(3);
                customer.password = reader.GetString(4);
                customer.address = reader.GetString(5);

                //Session["customer"] = customer;

                /*customer = new Models.Customer
                {
                    firstname = reader.GetString(1),
                    lastname = reader.GetString(2),
                    email = reader.GetString(3),
                    password = reader.GetString(4),
                    address = reader.GetString(5)
                };*/

                Session["customer"] = customer.firstname + " " +customer.lastname;
                //Response.Redirect("CustomerPageFR.aspx");
                Response.Redirect("~/Admin.aspx");

            }

            else
            {
                string userGroupe;
                //query = @"SELECT * FROM Users WHERE email='" + TextBoxEmail.Text + "' and password='" + EncryptedPassword + "'";
                query = @"SELECT * FROM Users WHERE email='" + TextBoxEmail.Text + "' and password='" + TextBoxPassword.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new Models.Users();
                    user.firstname = reader.GetString(1);
                    user.lastname = reader.GetString(2);
                    user.email = reader.GetString(3);
                    user.password = reader.GetString(4);
                    user.phone = reader.GetString(5);
                    userGroupe = user.UserGroup.ToString();
                    //user.ImageUrl = reader.GetString(6);
                    user.isAdmin = reader.GetBoolean(7);
                    //query = @"SELECT * FROM UserGroup WHERE user_id ='"+user.user_id+"'";
                    Session["user"] = user;
                    Session["Name"] = user.firstname;
                    Session["LastName"] = user.lastname;
                    Session["Email"] = user.email;
                    Session["Phone"] = user.phone;
                    Session["Groupe"] = user.UserGroup;
                    Session["isAdmin"] = user.isAdmin;
                   
                    //.Redirect("~/User.aspx");
                    Response.Redirect("~/Admin.aspx");

                }
                conn.Close();
                Btn_Cancel_Click(sender, e); //renvoyer le focus     
                //TextBoxEmail.Focus();//renvoyer le focus mais ne fait pas le clear du textbox

            }

        }
        protected void Btn_Cancel_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Text = " ";
            TextBoxPassword.Text = "";
            TextBoxEmail.Focus();
        }
        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CustomerRegister.aspx");
           
        }

        protected void BtnFacebook_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/Login facebook.aspx");
            Response.Redirect("~/PostOnFacebook.aspx");
        }
    }

    
}