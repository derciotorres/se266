﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            //do nothing...they are good
        }
        else
        {
            Response.Redirect("default.aspx");
        }

        string strPer_ID = "";
        int intPer_ID = 0;

        //Does Per_ID Exist?
        if ((!IsPostBack) && Request.QueryString["Per_ID"] != null)
        {
            //If so...Gather Person's ID and Fill Form
            strPer_ID = Request.QueryString["Per_ID"].ToString();
            //lblPerson_ID.Text = strPer_ID;

            intPer_ID = Convert.ToInt32(strPer_ID);

            //Fill the "temp" person's info based on ID
            post temp = new post();

            SqlDataReader reader = temp.FindOnepost(intPer_ID);
            reader.Read();
           String path = Server.MapPath("~/img/");
             fileuploadimages.PostedFile.SaveAs(path + fileuploadimages.FileName); 
          
            while (reader.Read())
            {

             
            txtTname.Text = reader["Tname"].ToString();
            txtCategory.Text = reader["Category"].ToString();
            txtDescription.Text = reader["Description"].ToString();
            txtTown.Text = reader["Description"].ToString();
            txtAddress.Text = reader["Description"].ToString();
            txtZip.Text = reader["Description"].ToString();
            txtFnumber.Text = reader["Description"].ToString();
            txtEmail.Text = reader["Description"].ToString();
            //fileuploadimages. = reader["photo"].ToString();


            }

        }
        else
        {
            //Do nothing....basic add page (empty)
        }

    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        post temp = new post();

        //Getting the strings from the form and setting them in object
        temp.Tname = txtTname.Text;
        temp.Category = txtCategory.Text;
        temp.Description = txtDescription.Text;
        temp.Town = txtTown.Text;
        temp.Address = txtAddress.Text;
        temp.Zip = txtZip.Text;
        temp.Fnumber = txtFnumber.Text;
        temp.Email = txtEmail.Text;
        temp.Photo = fileuploadimages.FileName;

        temp.User_ID = Convert.ToInt32(lbluser_ID.Text);


        //**************************************************************************


        if (!temp.Feedback.Contains("ERROR:"))
        {
            lblFeedback.Text = temp.UpdateARecord();   //if no errors weh setting values, then perform the insertion into db
        }
        else
        {
            lblFeedback.Text = temp.Feedback;       //else...dispay the error msg
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 intperson_ID = Convert.ToInt32(lbluser_ID.Text);  //Get the ID from the Label

        //Create a EBook so we can use the delete method
        post temp = new post();

        //Use the EBook ID and pass it to the delete function
        // and get the number of records deleted
        lblFeedback.Text = temp.DeleteOnepost(intperson_ID);

    }
}
