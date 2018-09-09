using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Controls_PersonSearch : System.Web.UI.Page
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

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        post temp = new post();
       

        DataSet ds = temp.Searchpost(txtTname.Text);

        gvpost.DataSource = ds;
        gvpost.DataMember = ds.Tables[0].TableName;
        gvpost.DataBind();
    }
}