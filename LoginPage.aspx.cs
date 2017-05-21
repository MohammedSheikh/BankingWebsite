using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void loginASPX_Click(object sender, EventArgs e)
    {
        DataTable dataTable = new DataTable();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        try
        {
            SqlConnection connection = new SqlConnection(DBConnection.ConnectionString);
           
            SqlCommand com = new SqlCommand("CUser", connection);

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Email", userName.Value.Trim());
            com.Parameters.AddWithValue("@CustomerPassword", password.Value.Trim());
            dataAdapter.SelectCommand = com;
            dataAdapter.Fill(dataTable);
            com.Dispose();

            if (userName.Value != "" && password.Value != "")
            {
                if (dataTable.Rows.Count > 0)
                {
                    var uniqueID = dataTable.Rows[0]["CustomerID"];
                    Session["id"] = uniqueID;

                    //var uniqueID = dataTable.Rows[0]["uniqueID"];
                    //Session["primaryID"] = uniqueID;

                    Response.Redirect("WelcomePage.aspx");
                }
                else
                {
                    Label1.Text = "Incorrect Details";
                }

                connection.Close();
            }
            else
            {
                Label1.Text = "Please enter required fields!";
            }

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Oops!! following error occured : " + ex.Message.ToString() + "');", true);
                     
        }
        finally
        {

            dataTable.Clear();
            dataTable.Dispose();
            
        }
    }
}