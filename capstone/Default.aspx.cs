﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
for (int i=0; i < 6; i++ ) { 
         post temp = new post();

        SqlDataReader reader = temp.FindOnepost(i+1);
        reader.Read();
        temp.Photo = reader["photo"].ToString();
        temp.Tname = reader["Tname"].ToString();
            String path = Server.MapPath("~/img/");
        //temp.Photo2 = System.Drawing.Image.FromFile( path+temp.Photo);
        
        
            if (i == 0)
            {
                Image1.ImageUrl = "~/img/" + temp.Photo;
        Label1.Text = temp.Tname;
            }
            else if( i == 1)
            {

                Image2.ImageUrl = "~/img/" + temp.Photo;
            }

            else if (i == 2)
            {

                Image3.ImageUrl = "~/img/" + temp.Photo;
            }

            else if (i == 3)
            {

                Image4.ImageUrl = "~/img/" + temp.Photo;
            }


            else if (i == 4)
            {

                Image5.ImageUrl = "~/img/" + temp.Photo;
            }

            else if (i == 5)
            {

                Image6.ImageUrl = "~/img/" + temp.Photo;
            }



        }

    }
}