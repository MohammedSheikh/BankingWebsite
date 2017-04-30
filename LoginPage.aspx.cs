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
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            SqlCommand com = new SqlCommand("CUser", connection);

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@email", userName.Value.Trim());
            com.Parameters.AddWithValue("@password", password.Value.Trim());
            dataAdapter.SelectCommand = com;
            dataAdapter.Fill(dataTable);
            com.Dispose();
            if (dataTable.Rows.Count > 0)
            {
                var firstName = dataTable.Rows[0]["FirstName"];
                Session["id"] = firstName;
                Response.Redirect("WelcomePage.aspx");
            }
            else
            {
                Label1.Text = "Incorrect Details";
            }

            connection.Close();
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Oops!! following error occured : " + ex.Message.ToString() + "');", true);
            // Response.Write("Oops!! following error occured: " +ex.Message.ToString());           
        }
        finally
        {

            dataTable.Clear();
            dataTable.Dispose();
            
        }
    }
}