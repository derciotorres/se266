using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Controls_Default : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection("Server=sql.neit.edu,4500;Database=se265_dercio;User Id=dercio;Password=neit2018;");


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from AdminSide where AdminUname='" + txtUser.Text + "'",  con);
        SqlDataReader dr = cmd.ExecuteReader();
        if(dr.Read())
        {
            if(dr["AdminPW"].ToString() == txtPass.Text)
            {
                Session["LoggedIn"] = "TRUE";
                //Shoot off to control panel
                Server.Transfer("control1.aspx");
            }
            else
            {
                lblFeedback.Text = "Something is wrong, Try agin !";
                Session.Abandon();
            }


        }


    


    }
}
