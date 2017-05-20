using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Payment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }

    protected void btnPayment_Click(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Today;

        string connString = DBConnection.ConnectionString;

        using (SqlConnection conn = new SqlConnection(connString))

        {
            string query = "INSERT into tblTransaction (TransactionName, TransactionDate, PaymentTotal, TransactionTypeID, FromAccount, ToAccount) values (@transactionName, @transactionDate, @paymentTotal, @transactionTypeID, @fromAccount, @toAccount);";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@transactionName", reference.Value);
            cmd.Parameters.AddWithValue("@transactionDate", dt);
            cmd.Parameters.AddWithValue("@paymentTotal", amount.Value);
            cmd.Parameters.AddWithValue("@transactionTypeID", 3);
            cmd.Parameters.AddWithValue("@fromAccount", Session["id"]);
            cmd.Parameters.AddWithValue("@toAccount", accountNo.Value);


            cmd.Connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Payment made successfully";
            }
            catch (Exception ex)
            {
                lblMessage.Text = Convert.ToString(ex);
                throw new Exception("Error " + ex.Message);
            }
        }

    }
}
