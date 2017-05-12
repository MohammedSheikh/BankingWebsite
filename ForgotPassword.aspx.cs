using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SendEmail_Click(object sender, EventArgs e)
    {

        string email = TextBox1.Text;

        MailMessage message = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        string emailTo = email;
        message.To.Add(new MailAddress(emailTo));
        message.Subject = "Password Reset";
        string link = String.Format("<a href=\"http://localhost:54158/ResetPassword\">Click here to reset your password.</a>");
        //message.Body = "Please click the following link to reset your banking password" + Environment.NewLine + "<a href=\"ResetPassword.aspx>";
        message.Body = link;
        message.IsBodyHtml = true;
        try
        {
            smtp.Send(message);
            lblmessage.Text = "Please check your email";
        }
        catch (Exception ex)
        {
            lblmessage.Text = "Please enter a valid email";
        }

      //http://localhost:54158/ResetPassword
    }
}