using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class register
{

    //My class with all my variables for my questions.
   
    private string uname;
    private string pword;
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
    public string Uname
    {
        get
        {
            return uname;
        }
        set
        { 
            if (ValidationLibrary.FilledIn(value))
            {
                uname = value;
            }
            else
            {

                feedback += "\nERROR: You must fill in your title name ";
            }

        }

    }//end tname
    public string Pword
    {
        get
        {
            return pword;
        }
        set
        {
            pword = value;

        }


    }//category CLOSE





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
        


            //Init string var
            string strResult = "";
       // byte[] imageData = ReadFile(txtphoto.Text);

        //Make a connection object
        SqlConnection Conn = new SqlConnection();

        //Initialize it's properties
        Conn.ConnectionString = @GetConnected();    //Set the Who/What/Where of DB
        


        string strSQL = "INSERT INTO Registration (Uname, Pword) VALUES (@Uname, @Pword)";
        // calling out the command
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;  //Commander knows what to say
        comm.Connection = Conn;     //Where's the phone?  Here it is

        //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
        comm.Parameters.AddWithValue("@Uname", Uname);
        comm.Parameters.AddWithValue("@Pword", Pword);
   

        //attempt to connect to the server
        try
        {
            Conn.Open();                                        //Open connection to DB - Think of dialing a friend on phone
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
    /*
    //**************************************************************************************
    //  NEW - Part one of drill-down search (Takes search params to narrow the search results
    //**************************************************************************************
    public DataSet SearchcemeteryV1(String strTname, String strCategory)
    {
        //Create a dataset to return filled
        DataSet ds = new DataSet();


        //Create a command for our SQL statement
        SqlCommand comm = new SqlCommand();


        //Write a Select Statement to perform Search
        String strSQL = "SELECT user_ID, Tname, category FROM post WHERE 0=0";

        //If the First/Last Name is filled in include it as search criteria
        if (strTname.Length > 0)
        {
            // % sign it means i dont care whats coming before and after
            strSQL += " AND Tname LIKE @Tname";
            comm.Parameters.AddWithValue("@Tname", "%" + strTname + "%");
        }
        if (strCategory.Length > 0)
        {
            strSQL += " AND Category LIKE @Category";
            comm.Parameters.AddWithValue("@Category", "%" + strCategory + "%");
        }


        //Create DB tools and Configure
        //*********************************************************************************************
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
        da.Fill(ds, "post_Temp");     //Fill the dataset with results from database and call it "personV2_Temp"
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

        //My SQL command string to pull up one EBook's data
        string sqlString =
       "SELECT * FROM post WHERE user_ID = @user_ID;";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@user_ID", intuser_ID);

        //Open the DataBase Connection and Yell our SQL Command
        conn.Open();

        //Return some form of feedback
        return comm.ExecuteReader();   //Return the dataset to be used by others (the calling form)

    }


    //Method that will delete one EBook record specified by the ID
    //It will return an Interger meant for feedback on how many 
    // records were deleted
    public string DeleteOnecemeteryV1(int intcemetery_ID)
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
       "DELETE FROM cemeteryV1 WHERE cemetery_ID = @cemetery_ID;";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@cemetery_ID", intcemetery_ID);

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




    /// <summary>
    /// NEW - Method to Update a Record in the DB
    /// </summary>
    /// <returns></returns>
    public string UpdateARecord()
    {
        Int32 intRecords = 0;
        string strResult = "";

        //Create SQL command string
        string strSQL = "UPDATE post SET Tname=@Tname, Category=@Category, Description=@Description, Photo=@Photo, Town=@Town, Address=@Address, Zip=@Zip, Fnumber=@Fnumber, Email=@Email  WHERE user_ID = @user_ID;";

        // Create a connection to DB
        SqlConnection conn = new SqlConnection();
        //Create the who, what where of the DB
        string strConn = GetConnected();
        conn.ConnectionString = strConn;

        // Bark out our command
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;  //Commander knows what to say
        comm.Connection = conn;     //Where's the phone?  Here it is

        //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
        comm.Parameters.AddWithValue("@Tname", Tname);
        comm.Parameters.AddWithValue("@Category", Category);
        comm.Parameters.AddWithValue("@Description", Description);
        //comm.Parameters.AddWithValue("@Photo", Photo);
        comm.Parameters.AddWithValue("@Town", Town);
        comm.Parameters.AddWithValue("@Address", Address);
        comm.Parameters.AddWithValue("@Zip", Zip);
        comm.Parameters.AddWithValue("@Fnumber", Fnumber);
        comm.Parameters.AddWithValue("@Email", Email);
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



    */


    private string GetConnected()
    {
        return "Server=sql.neit.edu,4500;Database=se265_dercio;User Id=dercio;Password=neit2018;";
    }

    public register()
    {//inicialize so that tere are no nulls  on feedback 
        uname = "";
        pword = "";
        feedback = "";

    }

}


