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
        // this are the fields i redirected from the default page
        Image1.ImageUrl = (string)Session["image"];
        lblTname1.Text = (string)Session["tname"];
        description1.Text = (string)Session["Description"];
        email.Text = (string)Session["Email"];
        town.Text = (string)Session["Town"];

        string strPer_ID = "";
        int intPer_ID = 0;
        //Does Per_ID Exist?
        if ((!IsPostBack) && Request.QueryString["Per_ID"] != null)
        {
            //If so...Gather post ID and Fill Form
            strPer_ID = Request.QueryString["Per_ID"].ToString();
            lblpost_ID.Text = strPer_ID;

            intPer_ID = Convert.ToInt32(strPer_ID);

            //Fill the "temp" user's info based on ID
            post temp = new post();

            SqlDataReader reader = temp.FindOnepost(intPer_ID);


            reader.Read();
            temp.Photo = reader["photo"].ToString();
            temp.Tname = reader["Tname"].ToString();
            temp.Description = reader["Description"].ToString();
            temp.Email = reader["Email"].ToString();
            temp.Town = reader["Town"].ToString();
            String path = Server.MapPath("~/img/");

             Image1.ImageUrl = "~/img/" + temp.Photo;
             lblTname1.Text = temp.Tname;
             description1.Text = temp.Description;
             town.Text = temp.Town;
        }

    
    }
    public void SendMail()
    {
        //MailMessage is the main class for sending mail, this is the part of the System.Net.Mail namespace.
        MailMessage mail = new MailMessage();
        mail.To.Add(email.Text);

        mail.From = new MailAddress("test19901809@gmail.com");
        mail.Subject = txtsubject.Text;
        string Body = txtmessage.Text;
        mail.Body = Body;
        SmtpClient smtp = new SmtpClient();
        //only works with gmail
        smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
        smtp.Port = 587;//port used for  Gmail
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