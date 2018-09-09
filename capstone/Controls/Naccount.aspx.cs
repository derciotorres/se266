using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Controls_Naccount : System.Web.UI.Page
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

    public void btnCreate_Click(object sender, EventArgs e)
    {
        

        SqlConnection con = new SqlConnection("Server=sql.neit.edu,4500;Database=se265_dercio;User Id=dercio;Password=neit2018;");
        //con.Open();

        string insert = "insert into AdminSide (AdminUname,AdminPW) values (@AdminUname,@AdminPW)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@AdminUname", txtUname.Text);
            cmd.Parameters.AddWithValue("@AdminPW", txtPW.Text);
            
          
       
        try
        {
            con.Open();                                        //Open connection to DB - Think of dialing a friend on phone
            int intRecs = cmd.ExecuteNonQuery();
            lblFeedback.Text = "SUCCESS: Inserted";
                                   //Report that we made the connection and added a record
            con.Close();                                      //Hanging up after phone call
        }
        catch (Exception err)                                   //If we got here, there was a problem connecting to DB
        {
            lblFeedback.Text = "ERROR: User Name already Exists ";
                         //Set feedback to state there was an error & error info
        }
        finally
        {

        }

        //Return resulting feedback string
    
    }
}