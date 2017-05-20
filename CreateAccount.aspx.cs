using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Today;

        string connString = DBConnection.ConnectionString;

        using (SqlConnection conn = new SqlConnection(connString))

        {
            string query = "INSERT into Account (AccountName, AccountTypeID, OpenedDate, CustomerID, BranchID) values (@accountName, @accountTypeID, @openedDate, @customerID, @branchID);";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@accountName", accountName.Value);
            cmd.Parameters.AddWithValue("@accountTypeID", accountType.Value);
            cmd.Parameters.AddWithValue("@openedDate", dt);
            cmd.Parameters.AddWithValue("@customerID", Session["id"]);
            cmd.Parameters.AddWithValue("@branchID", branch.Value);

            cmd.Connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Account Created Successfully.";
            }
            catch (Exception ex)
            {
                lblMessage.Text = Convert.ToString(ex);
                throw new Exception("Error " + ex.Message);                
            }
        }
    }
}