using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class WelcomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Label1.Text = Session["id"].ToString() + "!";
//The code below redirects to the login page if they user has logged out and tried to access the welcome page
        //if (Session["id"] == null)
        //{
        //    Response.Redirect("LoginPage.aspx");
        //}
        //else
        //{
            //Label1.Text = DataTable.Rows[0]["FirstName"];
            SqlConnection sqlConnection1 = new SqlConnection(DBConnection.ConnectionString);
            //SqlCommand cmd = new SqlCommand();
            // SqlDataReader reader;
            sqlConnection1.Open();

            //cmd.CommandText = "SELECT FirstName FROM Customer where CustomerID = " + Session["id"];
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = sqlConnection1;

            string result = "SELECT FirstName FROM Customer where CustomerID = " + Session["id"];
            SqlCommand showresult = new SqlCommand(result);
            
            //Label1.Text = showresult.ExecuteScalar().ToString();

        var firstColumn = showresult.ExecuteScalar();

        if (firstColumn != null)
        {
            Label1.Text = firstColumn.ToString();
        }

        //reader = cmd.ExecuteReader();
        // Data is accessible through the DataReader object here.

        sqlConnection1.Close();
       // }
    }


    
}