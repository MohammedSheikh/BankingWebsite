using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class WelcomePage : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        string name = null;
        string department = null;
        Boolean j = true;

        string sql = "SELECT FirstName FROM Customer where CustomerID =" + Session["id"];
        //change this connection string... visit www.connectionstrings.com
        string connString = DBConnection.ConnectionString;

        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
        else
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    //Error on this line
                    SqlDataReader reader = command.ExecuteReader();
                    while (j == true)
                    {
                        reader.Read();
                        name = reader[0] as string;
                        //break for single row or you can continue if you have multiple rows...
                        Label1.Text = name + " tst " + department;
                        break;

                    }
                }
                conn.Close();
            }
        }
    }
}

    


    
