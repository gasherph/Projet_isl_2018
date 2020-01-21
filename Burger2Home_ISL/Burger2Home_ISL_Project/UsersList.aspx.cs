using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Burger2Home_ISL_Project
{
    public partial class UsersList : System.Web.UI.Page
    {
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Burger2HomeConnectionString"].ConnectionString);
        //SqlConnection conn = new SqlConnection("Data Source = PC\\SQLEXPRESS;Initial Catalog = Burger2Home; Integrated Security = True");
        SqlConnection conn = new SqlConnection("Data Source = EPHREM-PC; Initial Catalog = Burger2Home; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void BindGrid()
        {
            DataSet ds = new DataSet();
            conn.Open();
            string query = "SELECT * FROM [dbo].[Users]";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            GrilleUpload.DataSource = ds;
            GrilleUpload.DataBind();
            conn.Close();
        }
        protected void BtnUpload_OnClick(object sender, EventArgs e)
        {
            TextBox TextBoxUserID = (TextBox)GrilleUpload.FooterRow.FindControl("TextBox_UserID");
            TextBox TextBoxUserName = (TextBox)GrilleUpload.FooterRow.FindControl("TextBox_UserName");
            TextBox TextBoxUserLastName = (TextBox)GrilleUpload.FooterRow.FindControl("TextBox_UserLastName");
            TextBox TextBoxUserEmail = (TextBox)GrilleUpload.FooterRow.FindControl("TextBox_UserEmail");
            TextBox TextBoxUserPassword = (TextBox)GrilleUpload.FooterRow.FindControl("TextBox_UserPassword");
            TextBox TextBoxUserPhone = (TextBox)GrilleUpload.FooterRow.FindControl("TextBox_UserPhone");
            FileUpload uploadFile = (FileUpload)GrilleUpload.FooterRow.FindControl("fUpload");
            Button btnUpload = (Button)GrilleUpload.FooterRow.FindControl("btnUpload");


            if (uploadFile.HasFile)
            {
                string fileName = uploadFile.FileName;
                string extension = Path.GetExtension(fileName);

                //here we have to restrict file type            
                extension = extension.ToLower();
                string[] acceptedFileTypes = new string[4];
                acceptedFileTypes[0] = ".jpg";
                acceptedFileTypes[1] = ".jpeg";
                acceptedFileTypes[2] = ".gif";
                acceptedFileTypes[3] = ".png";
                bool acceptFile = false;
                for (int i = 0; i <= 3; i++)
                {
                    if (extension == acceptedFileTypes[i])
                    {
                        acceptFile = true;
                    }
                }
                if (!acceptFile)
                {
                    lblMsg.Text = "The file you are trying to upload is not a permitted file type!";
                }
                //else
                //{


                //    //upload the file into the server                   
                //    fuploadFile.SaveAs(Server.MapPath("~/Photos/" + fileName.ToString()));
                //    //ImageBox.ImageUrl = fileName.ToString();

                //    conn.Open();
                //    ////string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox_password.Text, "SHA1");
                //    ////string query = "INSERT INTO [dbo].[Users](firstname,lastname,email,password,phone,ImageUrl) VALUES (@user_id,@firstname,@lastname,@email,@password,@phone,@ImageUrl)";
                //    //string query = @"INSERT INTO[dbo].[Users] ([firstname],[lastname],[email],[password],[phone],[ImageUrl]) VALUES('" + TextBox_firstname.Text + "', '" + TextBox_lastname.Text + "', '" + TextBox_email.Text + "','" + TextBox_password.Text + "','" + TextBox_Phone.Text + "','" + ImageBox.ToString() + "')";

                //    SqlCommand cmd = new SqlCommand(query, conn);

                //    cmd.Parameters.AddWithValue("@firstname", TextBox_UserID.Text);
                //    cmd.Parameters.AddWithValue("@firstname", TextB);
                //    cmd.Parameters.AddWithValue("@lastname", TextBox_lastname.Text);
                //    cmd.Parameters.AddWithValue("@email", TextBox_email.Text);
                //    cmd.Parameters.AddWithValue("@password", TextBox_password.Text);
                //    cmd.Parameters.AddWithValue("@phone", TextBox_Phone.Text);
                //    cmd.Parameters.AddWithValue("@ImageUrl", "Photos/" + fileName.ToString());
                //    cmd.ExecuteNonQuery();
                //    conn.Close();
                //    //BindGrid();
                //}
            }
        }
       
    }
    
}