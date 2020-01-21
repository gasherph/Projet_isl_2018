using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Burger2Home_ISL_Project
{
    public partial class NewUser : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Burger2HomeConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnUPLOAD_Click(object sender, EventArgs e)
        {         
            FileUpload fuploadFile = (FileUpload)btn_Browse.FindControl("btn_Browse");
            Button btnUpload = (Button)btnUPLOAD.FindControl("btnUPLOAD");
            if (fuploadFile.HasFile)
            {
                string fileName = fuploadFile.FileName;
                string extension = Path.GetExtension(fileName);

                //Reestricting file type 

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
                    LblMsg.Text = "The file you are trying to upload is not a permitted file type!";
                }

                else
                {
                    //upload the file into the server
                    
                    fuploadFile.SaveAs(Server.MapPath("~/Photos/" +fileName.ToString()));
                    ImageBox.ImageUrl = fileName.ToString();

                    conn.Open();
                    //string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox_password.Text, "SHA1");
                    //string query = "INSERT INTO [dbo].[Users](firstname,lastname,email,password,phone,ImageUrl) VALUES (@user_id,@firstname,@lastname,@email,@password,@phone,@ImageUrl)";
                    string query = @"INSERT INTO[dbo].[Users] ([firstname],[lastname],[email],[password],[phone],[ImageUrl]) VALUES('" + TextBox_firstname.Text + "', '" + TextBox_lastname.Text + "', '" + TextBox_email.Text + "','" + TextBox_password.Text + "','" + TextBox_Phone.Text + "','"+ImageBox.ToString() + "','" + CheckBoxIsAdmin + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);                   
                    //cmd.Parameters.AddWithValue("@firstname", TextBox_firstname.Text);
                    //cmd.Parameters.AddWithValue("@lastname", TextBox_lastname.Text);
                    //cmd.Parameters.AddWithValue("@email", TextBox_email.Text);
                    //cmd.Parameters.AddWithValue("@password", TextBox_password.Text);
                    //cmd.Parameters.AddWithValue("@phone", TextBox_Phone.Text);                   
                    //cmd.Parameters.AddWithValue("@ImageUrl", "Photos/" +fileName.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    //BindGrid();
                }
               
            }
        }
    }
}