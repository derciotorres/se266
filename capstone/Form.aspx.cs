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
       
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {


            post temp = new post();
        String path = Server.MapPath("~/img/");
        fileuploadimages.PostedFile.SaveAs(path + fileuploadimages.FileName);
       
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



            if (!temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.AddARecord();   //if no errors weh setting values, then perform the insertion into db
            }
            else
            {
                lblFeedback.Text = temp.Feedback;       //else...dispay the error msg
            }


        


    }


}