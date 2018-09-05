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
        
        int count = Int32.Parse(lblRows2.Text);

        post dummy = new post();

        SqlDataReader reader = dummy.Findbottom6();
   
        for ( int i = 0 ; i < 6  ; i++)
        {
        
            post temp = new post();
            
            //reader.HasRows
            if (reader.Read())
            {
                temp.Photo = reader["photo"].ToString();
                temp.Tname = reader["Tname"].ToString();
                temp.Description = reader["Description"].ToString();
                temp.Email = reader["Email"].ToString();
                String path = Server.MapPath("~/img/");



                if (i == 0)
                {
                    Image1.ImageUrl = "~/img/" + temp.Photo;
                    lblTname1.Text = temp.Tname;
                    description1.Text = temp.Description;
                    email1.Text = temp.Email;
                }
                else if (i ==  1)
                {

                    Image2.ImageUrl = "~/img/" + temp.Photo;
                    lblTname2.Text = temp.Tname;
                    description2.Text = temp.Description;
                    email2.Text = temp.Email;
                }

                else if (i ==  2)
                {

                    Image3.ImageUrl = "~/img/" + temp.Photo;
                    lblTname3.Text = temp.Tname;
                    description3.Text = temp.Description;
                    email3.Text = temp.Email;
                }

                else if (i == 3)
                {

                    Image4.ImageUrl = "~/img/" + temp.Photo;
                    lblTname4.Text = temp.Tname;
                    description4.Text = temp.Description;
                    email4.Text = temp.Email;
                }


                else if (i == 4)
                {

                    Image5.ImageUrl = "~/img/" + temp.Photo;
                    lblTname5.Text = temp.Tname;
                    description5.Text = temp.Description;
                    email5.Text = temp.Email;
                }

                else if (i == 5)
                {

                    Image6.ImageUrl = "~/img/" + temp.Photo;
                    lblTname6.Text = temp.Tname;
                    description6.Text = temp.Description;
                    email6.Text = temp.Email;
                }



            }



        }

    }

         
            
      

    protected void btnopen1_Click(object sender, EventArgs e)
    {


        Session["image"] = Image1.ImageUrl;
        Session["Tname"] = lblTname1.Text;
        Session["Description"] = description1.Text;
        Session["Email"] = email1.Text;
        Response.Redirect("Display.aspx");


    }
    protected void btnopen2_Click(object sender, EventArgs e)
    {


        Session["image"] = Image2.ImageUrl;
        Session["Tname"] = lblTname2.Text;
        Session["Description"] = description2.Text;
        Session["Email"] = email2.Text;
        Response.Redirect("Display.aspx");


    }

    protected void btnopen3_Click(object sender, EventArgs e)
    {


        Session["image"] = Image3.ImageUrl;
        Session["Tname"] = lblTname3.Text;
        Session["Description"] = description3.Text;
        Session["Email"] = email3.Text;
        Response.Redirect("Display.aspx");


    }
    protected void btnopen4_Click(object sender, EventArgs e)
    {


        Session["image"] = Image4.ImageUrl;
        Session["Tname"] = lblTname4.Text;
        Session["Description"] = description4.Text;
        Session["Email"] = email4.Text;
        Response.Redirect("Display.aspx");


    }
    protected void btnopen5_Click(object sender, EventArgs e)
    {


        Session["image"] = Image5.ImageUrl;
        Session["Tname"] = lblTname5.Text;
        Session["Description"] = description5.Text;
        Session["Email"] = email5.Text;
        Response.Redirect("Display.aspx");


    }
    protected void btnopen6_Click(object sender, EventArgs e)
    {


        Session["image"] = Image6.ImageUrl;
        Session["Tname"] = lblTname6.Text;
        Session["Description"] = description6.Text;
        Session["Email"] = email6.Text;
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
