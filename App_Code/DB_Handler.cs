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
    // static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Yasar\\Documents\\Visual Studio 2015\\Projects\\New folder\\BankingWebsite\\App_Data\\BankingData.mdf;Integrated Security=True");
    static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alam\\Documents\\Banking_Project\\App_Data\\BankingData.mdf;Integrated Security=True");
    static SqlCommand cmd;
    static SqlDataReader dr;
    public DB_Handler()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static void saveUser(string fName, string lName, string gender1, string mStatus1, string dob1, string cob1, string 
                                    nationality1, string postcode1, string houseno1, string phoneno1, string email1)
    {
        con.Open();
        cmd = new SqlCommand("INSERT into Customer (Title, FirstName, LastName, DOB, AddressOne, PostCode, Email, HomePhone, Gender, Nationality, MaritalStatus) Values('Mr', '"+fName+"', '"+lName+"', '"+dob1+"', '"+houseno1+"', '"+postcode1+"', '"+email1+"', '"+phoneno1+"', '"+gender1+"', '"+nationality1+"', '"+mStatus1+"')", con);
        dr = cmd.ExecuteReader();
        dr.Read();

    }
}