using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
      /*  if (Page.IsValid)
        {
            btnInsert.AlternateText = "Valid";
        }
        else
        {
            btnInsert.AlternateText = "Invalid!";
        }

    */
        register temp = new register();

 
        temp.Uname = txtUname.Text;
        temp.Pword = txtPword.Text;
        temp.Pword2 = txtPword2.Text;

        if (!temp.Feedback.Contains("ERROR:"))
        {
            lblFeedback.Text = temp.AddARecord();   //if no errors weh setting values, then perform the insertion into db
            Response.Write("<script>alert('Sucess ');</script>");

            Server.Transfer("default.aspx");
        }
        else
        {
            lblFeedback.Text = temp.Feedback;
            Response.Write("<script>alert('Try again ');</script>");//else...dispay the error msg
        }





    }
}