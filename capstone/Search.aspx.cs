using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        post temp = new post();
        txtTname.Text = Request.QueryString["search"];

        DataSet ds = temp.Searchpost(txtTname.Text);
         //grabing the date from the id's on my function , in this case im ust grabbing it from the title names'
        gvpost.DataSource = ds;
        gvpost.DataMember = ds.Tables[0].TableName;
        gvpost.DataBind();


    }

}