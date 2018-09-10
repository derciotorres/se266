using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{

    SqlConnection con = new SqlConnection("Server=sql.neit.edu,4500;Database=se265_dercio;User Id=dercio;Password=neit2018;");

    protected void Page_Load(object sender, EventArgs e)
    {

      

        if (Session["LoggedIn"] == null)
        {
          
            btnLogout.Visible = false;
         btndonate.Visible = false;
          btnsign.Visible = true;
          btnlog.Visible = true;

        }
        else
        {

         
            
            btnLogout.Enabled = true;
          btndonate.Visible = true;
           btnsign.Visible = false;
           btnlog.Visible = false;
        }

    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
     
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from Registration where Uname='" + txtUser.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            if (dr["Pword"].ToString() == txtPass.Text)
            {
                if (txtUser.Text.Length == 0)
                {
                    Response.Write("<script>alert('Try Again ');</script>");

                }
                else
                {
                    Session["LoggedIn"] = "TRUE";
                    Response.Write("<script>alert('Welcome ');</script>");
               
                    //Shoot off to main page
                    Server.Transfer("default.aspx");

                }

            
            }
            else
            {
                Response.Write("<script>alert('Try Again ');</script>");
                lblFeedback.Text = "Something is wrong, Try agin !";
                Server.Transfer("default.aspx");
                Session.Abandon();
            }


        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("Search.aspx?search=" + txtsearch.Text);

    }


    protected void btnLogout_Click(object sender, EventArgs e)
    {
       
        Session.Abandon();
        Response.Redirect("default.aspx");

    }

}
