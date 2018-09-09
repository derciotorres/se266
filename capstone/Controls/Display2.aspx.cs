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
        lblTname1.Text = (string)Session["tname"];
        description1.Text = (string)Session["Description"];

        string strPer_ID = "";
        int intPer_ID = 0;
        //Does Per_ID Exist?
        if ((!IsPostBack) && Request.QueryString["Per_ID"] != null)
        {
            //If so...Gather Person's ID and Fill Form
            strPer_ID = Request.QueryString["Per_ID"].ToString();
            lblpost_ID.Text = strPer_ID;

            intPer_ID = Convert.ToInt32(strPer_ID);

            //Fill the "temp" person's info based on ID
            post temp = new post();

            SqlDataReader reader = temp.FindOnepost(intPer_ID);


            reader.Read();
            temp.Photo = reader["photo"].ToString();
            temp.Tname = reader["Tname"].ToString();
            temp.Description = reader["Description"].ToString();
            String path = Server.MapPath("~/img/");

             Image1.ImageUrl = "~/img/" + temp.Photo;
                lblTname1.Text = temp.Tname;
                description1.Text = temp.Description;
        }

    
    }
  
}