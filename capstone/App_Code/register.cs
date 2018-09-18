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
    private string pword2;
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

    }//end Uname
    public string Pword
    {
        get
        {
            return pword;
        }
        set
        {
            if (ValidationLibrary.FilledIn(value))
            {
                pword = value;
            }
            else
            {

                feedback += "\nERROR: You must fill in your title name ";
            }

        }


    }//Pword CLOSE
    public string Pword2
    {
        get
        {
            return pword2;
        }
        set
        {
            if (ValidationLibrary.FilledIn(value))
            {
                pword2 = value;
            }
            else
            {

                feedback += "\nERROR: You must fill in your title name ";
            }
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


        //Make a connection object
        SqlConnection Conn = new SqlConnection();

        //Initialize it's properties
        Conn.ConnectionString = @GetConnected();    //Set the Who/What/Where of DB
        


        string strSQL = "INSERT INTO Registration (Uname, Pword,Pword2) VALUES (@Uname, @Pword, @Pword2)";
        // calling out the command
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;  //Commander knows what to say
        comm.Connection = Conn;     //Where's the phone?  Here it is

        //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
        comm.Parameters.AddWithValue("@Uname", Uname);
        comm.Parameters.AddWithValue("@Pword", Pword);
        comm.Parameters.AddWithValue("@Pword2", Pword2);

        //attempt to connect to the server
        try
        {
            Conn.Open();                                        //Open connection to DB
            int intRecs = comm.ExecuteNonQuery();
            strResult = "SUCCESS: Inserted " + intRecs + " records.";       //Report that we made the connection and added a record
            Conn.Close();                                    
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
    
  
    public DataSet SearchRegister(String strUname)
    {
        //Create a dataset to return filled
        DataSet ds = new DataSet();


        //Create a command for our SQL statement
        SqlCommand comm = new SqlCommand();


        //Write a Select Statement to perform Search
        String strSQL = "SELECT user_ID, Uname FROM Registration WHERE 0=0";

        //If Uname is filled in include it as search criteria
        if (strUname.Length > 0)
        {
            // % sign it means i dont care whats coming before and after
            strSQL += " AND Uname LIKE @Uname";
            comm.Parameters.AddWithValue("@Uname", "%" + strUname + "%");
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
        da.Fill(ds, "registration_Temp");     //Fill the dataset with results from database and call it "personV2_Temp"
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
       "SELECT * FROM Registration WHERE user_ID = @user_ID;";

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
    public string DeleteOnepost(int intuser_ID)
    {
        Int32 intRecords = 0;
        string strResult = "";

        //Create and Initialize the DB Tools we need
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //My Connection String
        string strConn = GetConnected();

        //My SQL command string to pull up one Registration data
        string sqlString =
       "DELETE FROM Registration WHERE User_ID = @User_ID;";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@User_ID", intuser_ID);

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
        string strSQL = "UPDATE Registration SET Uname=@Uname, Pword=@Pword, Pword2=@Pword2  WHERE user_ID = @user_ID;";
        // Create a connection to DB
        SqlConnection conn = new SqlConnection();
        //Create the who, what where of the DB
        string strConn = GetConnected();
        conn.ConnectionString = strConn;

        // Bark out our command
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;  //Commander knows what to say
        comm.Connection = conn;     

        comm.Parameters.AddWithValue("@Uname", Uname);
        comm.Parameters.AddWithValue("@Pword", Pword);
        comm.Parameters.AddWithValue("@Pword2", Pword2);
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

    public register()
    {//inicialize so that tere are no nulls  on feedback 
        uname = "";
        pword = "";
        pword2 = "";
        feedback = "";

    }

}


