using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
   {
        SqlConnection con = new SqlConnection("Server=sql.neit.edu,4500;Database=se265_dercio;User Id=dercio;Password=neit2018;");
        SqlCommand cmd;
        string sql = "SELECT COUNT(user_ID)FROM postv1";
        try
        {
            con.Open();

            lblRows.Text=" Database connected ...!";
            cmd = new SqlCommand(sql, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblRows2.Text = rows_count.ToString();

        }
        catch(Exception)
        {

            Response.Write("<script>alert('Welcome ');</script>");

        }
        finally
        {
            

        }





        for (int i = 0; i < 6; i++ ) { 
         post temp = new post();

        SqlDataReader reader = temp.FindOnepost(i+1);
        reader.Read();
        temp.Photo = reader["photo"].ToString();
        temp.Tname = reader["Tname"].ToString();
        temp.Description = reader["Description"].ToString();
            String path = Server.MapPath("~/img/");

        
        
            if (i == 5)
            {
                Image1.ImageUrl = "~/img/" + temp.Photo;
                Label1.Text = temp.Tname;
                Label7.Text = temp.Description;       
            }
            else if( i == 4)
            {

                Image2.ImageUrl = "~/img/" + temp.Photo;
                Label2.Text = temp.Tname;
            }

            else if (i == 3)
            {

                Image3.ImageUrl = "~/img/" + temp.Photo;
                Label3.Text = temp.Tname;
            }

            else if (i == 2)
            {

                Image4.ImageUrl = "~/img/" + temp.Photo;
                Label4.Text = temp.Tname;
            }


            else if (i == 1)
            {

                Image5.ImageUrl = "~/img/" + temp.Photo;
                Label5.Text = temp.Tname;
                Label8.Text = temp.Description;
            }

            else if (i == 0)
            {

                Image6.ImageUrl = "~/img/" + temp.Photo;
                Label6.Text = temp.Tname;
            }



        }



    }

    protected void btnopen1_Click(object sender, EventArgs e)
    {


        Session["test"] = Image1.ImageUrl;
        Session["test1"] = Label1.Text;
        Session["test2"] = Label7.Text;
        Response.Redirect("Display.aspx");


    }

    protected void btnopen5_Click(object sender, EventArgs e)
    {


        Session["test"] = Image5.ImageUrl;
        Session["test1"] = Label5.Text;
        Session["test2"] = Label8.Text;
        Response.Redirect("Display.aspx");


    }
    protected void btnopen_Click(object sender, EventArgs e)
    {




    }


}
/* ImageButton objImage = (ImageButton)sender;
 String id = objImage.ImageUrl;
 string name = objImage +"Label";
  Session["name"]=name.Tex
 Session["ID"] = id;


 Response.Redirect("Display.aspx");
  SqlConnection con = new SqlConnection("Server=sql.neit.edu,4500;Database=se265_dercio;User Id=dercio;Password=neit2018;");
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT COUNT(user_ID) FROM postv1",con);
        SqlDataReader dr = cmd.ExecuteReader();
        
                object o = cmd.ExecuteScalar();
                if (o != null)
                {
                    lblRows.Text = "Total No of Rows: " + o.ToString();
                }
                con.Close();
*/
