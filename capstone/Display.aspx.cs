using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Image1.ImageUrl = (string)Session["image"];
        Label1.Text = (string)Session["tname"];
        Label2.Text = (string)Session["Description"];
    }
    public void SendMail()
    {
        MailMessage mail = new MailMessage();
        mail.To.Add(txtTo.Text);

        mail.From = new MailAddress("test19901809@gmail.com");
        mail.Subject = "TakeIt!";
        string Body = txtmessage.Text;
        mail.Body = Body;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
        smtp.Port = 587;
        smtp.UseDefaultCredentials = false;
        smtp.Credentials = new System.Net.NetworkCredential
        ("test19901809@gmail.com", "001425990");

        //Or your Smtp Email ID and Password
        smtp.EnableSsl = true;
        smtp.Send(mail);
    }
    public void Bttn_Send_Click(object sender, EventArgs e)
    {

        SendMail();
        Response.Write("<script>alert('Sent ');</script>");

    }
}