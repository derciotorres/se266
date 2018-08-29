﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["test"]))
        {
            Image1.ImageUrl = Request.QueryString["test"];
        }
        else
        {
            Image1.ImageUrl = "NO DATA PROVIDED OR COULD NOT BE READ";
        }

    }
}