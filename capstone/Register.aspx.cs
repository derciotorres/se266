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

        register temp = new register();

 
        temp.Uname = txtUname.Text;
        temp.Pword = txtPword.Text;


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