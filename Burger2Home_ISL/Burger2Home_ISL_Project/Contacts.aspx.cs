using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Net.Mail;//***************//

namespace Burger2Home_ISL_Project
{
    public partial class Contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlGenericControl customers = (HtmlGenericControl)Master?.FindControl("customers");
            HtmlGenericControl categories = (HtmlGenericControl)Master?.FindControl("categories");
            HtmlGenericControl ingredients = (HtmlGenericControl)Master?.FindControl("ingredients");
            HtmlGenericControl burgers = (HtmlGenericControl)Master?.FindControl("burgers");
            HtmlGenericControl orders = (HtmlGenericControl)Master?.FindControl("orders");

            customers.Visible = false;
            categories.Visible = false;
            ingredients.Visible = false;
            burgers.Visible = false;
            orders.Visible = false;

        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (Page.IsValid) // To ensure that all validations are succeded! or to be sure that this code will not be executed in case of Exception
                {
                    //MailMessage mailMessage = new MailMessage();//MailMessage peut être utiliser de 4 manières différentes
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("gasherph2012@gmail.com"); //the from address
                    mailMessage.To.Add("gasherph2012@gmail.com");
                    mailMessage.Subject = txtSubject.Text;
                    mailMessage.Body = "<b> Sender Name : </b>" + txtName.Text + "<br/>"
                                      + "<b> Sender Email : </b>" + txtEmail.Text + "<br/>"
                                      + "<b> Comments : </b>" + txtComments.Text;
                    mailMessage.IsBodyHtml = true;//to specify that the body of the above email that contains Html

                    /*Configuration  pour envoyer l'email en question qui peut se faire dans WebCongif aussi mais pas les deux à la fois!*/

                    //SmtpClient smtpClient = new SmtpClient("smtp.live.com", 25);//HOTMAIL SMTP SERVER = smtp.live.com and PORT NUMBER = 25
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);//GMAIL SMTP SERVER = smtp.gmail.com and PORT NUMBER = 587
                    smtpClient.EnableSsl = true; 

                    smtpClient.Credentials = new System.Net.NetworkCredential()
                    {
                        UserName = "gasherph2012@gmail.com",
                        Password = "Tito@2016"
                    };

                    /* Ce qu'il faut mettre en cas de configuration dans WebConfig 
                     * 
                        SmtpClient smtpClient = new SmtpClient();                
                        smtpClient.Send(mailMessage);//sending the email
                     *
                    */
                    Label1.ForeColor = System.Drawing.Color.Blue;
                    Label1.Text = "Thank you for contacting us!";

                    txtName.Enabled = false;
                    txtComments.Enabled = false;
                    txtEmail.Enabled = false;
                    txtSubject.Enabled = false;
                    BtnSubmit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                //Log -Event Viewer or table

                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "There is unkown problem.Please try later !" +ex.Message;
            }
        }
    }
}