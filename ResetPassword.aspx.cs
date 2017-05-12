using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResetPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //this button enables users password to be changed
    protected void Button1_Click(object sender, EventArgs e)
    {
        string connString = DBConnection.ConnectionString;
        using (SqlConnection conn = new SqlConnection(connString))
        {
            //SQL Update query
            string query = "UPDATE Customer SET Password = @password where Email = @email";
            SqlCommand cmd = new SqlCommand(query, conn);
            //add param values
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            //open the connection
            cmd.Connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            lblMessage.Text = "Your password has been updated. You will now be taken to the Login page.";
            //timer that redirects to login page after 3 seconds
            Response.AddHeader("REFRESH", "3;URL=LoginPage.aspx");
        }
    }
}