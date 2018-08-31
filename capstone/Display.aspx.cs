using System;
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
        if (!string.IsNullOrEmpty((string)Session["test"]))
        {
            Image1.ImageUrl = (string)Session["test"];
            Label1.Text = (string)Session["test1"];
            Label2.Text = (string)Session["test2"];
        }
        else
        {
            Image1.ImageUrl = "NO DATA PROVIDED OR COULD NOT BE READ";
        }

    }
}