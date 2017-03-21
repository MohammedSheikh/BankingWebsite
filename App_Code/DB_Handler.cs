using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DB_Handler
/// </summary>
public class DB_Handler
{
     static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Yasar\\Documents\\Visual Studio 2015\\Projects\\New folder\\BankingWebsite\\App_Data\\BankingData.mdf;Integrated Security=True");
    static SqlCommand cmd;
    static SqlDataReader dr;
    public DB_Handler()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static void saveUser(string fName, string lName )
    {
        con.Open();
        cmd = new SqlCommand("INSERT into Customer (Title, FirstName, LastName) Values ('Mr', '"+fName+"', '"+lName+"')", con);
        dr = cmd.ExecuteReader();
        dr.Read();


    }
}