using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Controls_control1 : System.Web.UI.Page
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
    }

    protected void btnuser_Click(object sender, EventArgs e)
    {
        Server.Transfer("usersearch.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Server.Transfer("Postsearch.aspx");   
    }

    protected void btnAccount_Click(object sender, EventArgs e)
    {
        Server.Transfer("Naccount.aspx");

    }
}


