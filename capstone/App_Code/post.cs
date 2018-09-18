using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class post
{

    //My class with all my variables
   
    private string tname;
    private string category;
    private string description;
    private string town;
    private string address;
    private string zip;
    private string fnumber;
    private string email;
    private string photo;
    private System.Drawing.Image photo2;
    protected string feedback;// allows the outside program to see feedback
    private int user_ID;



    // this where i have all my accessors/ mutators are to allow me to gather the private information as well as to allow to modifie it.




    public Int32 User_ID
    {
        get
        {
            return user_ID;
        }

        set
        {
            //if we have the miimum number of pages needed...
            if (value >= 0)
            {
                user_ID = value;  //store the # of pages
            }
            else
            {
                //Store an error msg in Feedback
                feedback += "\nERROR: Sorry you entered an invalid user ID.";
            }
        }
    }
    public string Tname
    {
        get
        {
            return tname;
        }
        set
        { 
            if (ValidationLibrary.FilledIn(value))
            {
                tname = value;
            }
            else
            {

                feedback += "\nERROR: You must fill in your title name ";
            }

        }

    }//end tname
    public string Category
    {
        get
        {
            return category;
        }
        set
        {
            category = value;

        }


    }//category CLOSE

    public string Description
    {
        get
        {
            return description;
        }
        set
        {//checking if its filled in 
            if (ValidationLibrary.FilledIn(value))
            {
                description = value;
            }
            else
            {

                feedback += "\nERROR: You must fill in your description ";
            }


        }
    }//description close

    public string Town
    {
        get
        {
            return town;
        }

        set
        {
            if (ValidationLibrary.FilledIn(value))
            {
                town = value;
            }
            else
            {

                feedback += "\nERROR: You must fill in your Town ";
            }
        }
    }//end town

    public string Address
    {
        get
        {
            return address;
        }
        set
        {
            if (ValidationLibrary.FilledIn(value))
            {
                address = value;
            }
            else
            {

                feedback += "\nERROR: You must fill in your Address ";
            }


        }
    }//address close



    public string Zip
    {
        get
        {
            return zip;
        }
        set
        {
            if (ValidationLibrary.ZipCode(value))
            {
                zip = value;
            }
            else
            {

                feedback += "\nERROR: You must fill with a correct Zipcode ";
            }

        }
    }//zip close


    public string Fnumber
    {
        get
        {
            return fnumber;
        }
        set
        {
            if (ValidationLibrary.IsValidPhone(value))
            {
                fnumber = value;
            }
            else
            {

                feedback += "\nERROR: You must fill with a correct Phone Number";
            }

        }
    }//Fnumber close

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (ValidationLibrary.emailIsValid(value))
            {
                email = value;
            }
            else
            {

                feedback += "\nERROR: You must fill with an valid email address";
            }

        }
    }//email close

    public string Photo
    {
        get
        {
            return photo;
        }
        set
        {
            photo = value;

        }
    }//photo close

    public System.Drawing.Image Photo2
 {
     get
     {
         return photo2;
     }
     set
     {
         photo2 = value;

     }
 }//photo close

    // here on feedback im allowing the class to comunicate with the outside programs 
    public string Feedback
    {
        get
        {
            return feedback;
        }
    }//feedback close





    public string AddARecord()
    {

        string strResult = "";

       

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @GetConnected();    //Set the Who/What/Where of DB



            string strSQL = "INSERT INTO Postv1 (Tname, Category, Description, Town, Address, Zip, Fnumber, Email, Photo) VALUES (@Tname, @Category, @Description, @Town, @Address, @Zip, @Fnumber, @Email, @Photo)";
            // calling out the command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = Conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@Tname", Tname);
            comm.Parameters.AddWithValue("@Category", Category);
            comm.Parameters.AddWithValue("@Description", Description);
            comm.Parameters.AddWithValue("@Town", Town);
            comm.Parameters.AddWithValue("@Address", Address);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Fnumber", Fnumber);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Photo", Photo);

            //attempt to connect to the server
            try
            {
                Conn.Open();                                        //Open connection to DB 
                int intRecs = comm.ExecuteNonQuery();
                strResult = "SUCCESS: Inserted " + intRecs + " records.";       //Report that we made the connection and added a record
                Conn.Close();                                      //Hanging up after phone call
            }
            catch (Exception err)                                   //If we got here, there was a problem connecting to DB
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {

            }

            //Return resulting feedback string
            return strResult;
        }
    


    public DataSet Searchpost(String strTname)
    {
        //Create a dataset to return filled
        DataSet ds = new DataSet();


        //Create a command for our SQL statement
        SqlCommand comm = new SqlCommand();


        //Write a Select Statement to perform Search
        String strSQL = "SELECT user_ID, Tname FROM Postv1 WHERE 0=0";

        //If the First/Last Name is filled in include it as search criteria
        if (strTname.Length > 0)
        {
            // % sign it means i dont care whats coming before and after
            strSQL += " AND Tname LIKE @Tname";
            comm.Parameters.AddWithValue("@Tname", "%" + strTname + "%");
        }



        //Create DB tools and Configure
        SqlConnection conn = new SqlConnection();
        //Create the who, what where of the DB
        string strConn = @GetConnected();
        conn.ConnectionString = strConn;

        //Fill in basic info to command object
        comm.Connection = conn;     //tell the commander what connection to use
        comm.CommandText = strSQL;  //tell the command what to say

        //Create Data Adapter
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comm;    //commander needs a translator(dataAdapter) to speak with datasets

        //*********************************************************************************************

        //Get Data
        conn.Open();                //Open the connection 
        da.Fill(ds, "post_Temp");     //Fill the dataset with results from database and call it "post_Temp"
        conn.Close();               //Close the connection 

        //Return the data
        return ds;
    }



    public SqlDataReader FindOnepost(int intuser_ID)
    {
        //Create and Initialize the DB Tools we need
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //My Connection String
        string strConn = GetConnected();

        //My SQL command string to pull up one post data
        string sqlString = "SELECT * FROM Postv1 WHERE User_ID = @User_ID ";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@User_ID", intuser_ID);
      
            //Open the DataBase Connection and Yell our SQL Command
            conn.Open();
        
        return comm.ExecuteReader();
        

    }

    public  SqlDataReader Findbottom6()
    {
        //function to give me the top 6 in descent order for my main page
        //Create and Initialize the DB Tools we need
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //My Connection String
        string strConn = GetConnected();

        //My SQL command string to pull up one post data
        string sqlString = "SELECT TOP (6) User_ID,Tname,Category,Description,Email,Town,photo  from Postv1 order by User_ID DESC ";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
       

        //Open the DataBase Connection and Yell our SQL Command
        conn.Open();

        return comm.ExecuteReader();


    }



    public string getcount(int intcount_ID)
    {
        Int32 intRecords = 0;
        string strResult = "";

        //Create and Initialize the DB Tools we need
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //My Connection String
        string strConn = GetConnected();

        //My SQL command string to pull up one EBook's data
        string sqlString =
       "SELECT COUNT(user_ID) FROM postv1;";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@User_ID", intcount_ID);

        try
        {
            //Open the connection
            conn.Open();

            //Run the Delete and store the number of records effected
            intRecords = comm.ExecuteNonQuery();
            strResult = intRecords.ToString() + " Number of records";
        }
        catch (Exception err)
        {
            strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
        }
        finally
        {
            //close the connection
            conn.Close();
        }

        return strResult;


    }


   
    public string DeleteOnepost(int intuser_ID)
    {
        Int32 intRecords = 0;
        string strResult = "";

        //Create and Initialize the DB Tools we need
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //My Connection String
        string strConn = GetConnected();

        //My SQL command string to pull up post data
        string sqlString =
       "DELETE FROM postV1 WHERE User_ID = @User_ID;";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@user_ID", intuser_ID);

        try
        {
            //Open the connection
            conn.Open();

            //Run the Delete and store the number of records effected
            intRecords = comm.ExecuteNonQuery();
            strResult = intRecords.ToString() + " Records Deleted.";
        }
        catch (Exception err)
        {
            strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
        }
        finally
        {
            //close the connection
            conn.Close();
        }

        return strResult;


    }

   





    public string UpdateARecord()
    {
        Int32 intRecords = 0;
        string strResult = "";

        //Create SQL command string
        string strSQL = "UPDATE postV1 SET Tname=@Tname, Category=@Category, Description=@Description, Town=@Town, Address=@Address, Zip=@Zip, Fnumber=@Fnumber, Email=@Email, Photo=@Photo  WHERE User_ID = @User_ID;";

        // Create a connection to DB
        SqlConnection conn = new SqlConnection();
        //Create the who, what where of the DB
        string strConn = GetConnected();
        conn.ConnectionString = strConn;

        //  command
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;  //Commander knows what to say
        comm.Connection = conn;     //Where's the phone?  Here it is

        //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
        comm.Parameters.AddWithValue("@Tname", Tname);
        comm.Parameters.AddWithValue("@Category", Category);
        comm.Parameters.AddWithValue("@Description", Description);
        comm.Parameters.AddWithValue("@Town", Town);
        comm.Parameters.AddWithValue("@Address", Address);
        comm.Parameters.AddWithValue("@Zip", Zip);
        comm.Parameters.AddWithValue("@Fnumber", Fnumber);
        comm.Parameters.AddWithValue("@Email", Email);
        comm.Parameters.AddWithValue("@Photo", Photo);
        comm.Parameters.AddWithValue("@user_ID", user_ID);
        try
        {
            //Open the connection
            conn.Open();

            //Run the Update and store the number of records effected
            intRecords = comm.ExecuteNonQuery();
            strResult = intRecords.ToString() + " Records Updated.";
        }
        catch (Exception err)
        {
            strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
        }
        finally
        {
            //close the connection
            conn.Close();
        }

        return strResult;

    }






    private string GetConnected()
    {
        return "Server=sql.neit.edu,4500;Database=se265_dercio;User Id=dercio;Password=neit2018;";
    }

    public post()
    {//inicialize so that there are no nulls  on feedback 
        tname = "";
        category = "";
        description = "";
        town = "";
        address = "";
        zip = "";
        Fnumber = "";
        email = "";
        photo = null;
        feedback = "";

    }

}


