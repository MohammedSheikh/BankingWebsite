using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Statement : System.Web.UI.Page
{

    static double displayBalance = 50;
    CurrentAccount ba = new CurrentAccount(displayBalance);


    StudentAccount st = new StudentAccount(displayBalance);

    protected void Page_Load(object sender, EventArgs e)
    {

        int accountNumber1 = 0;
        int sortCode1 = 0;
        bool j = true;

        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
        else
        {
            try
            {
                string sql = "SELECT AccountID, BranchID FROM Account where CustomerID =" + Session["id"];
                string connString = DBConnection.ConnectionString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (j == true)
                        {
                            reader.Read();

                            accountNumber1 = Convert.ToInt32(reader["AccountID"]);
                            sortCode1 = Convert.ToInt32(reader["BranchID"]);
                            accountNumber.Text = Convert.ToString(accountNumber1);
                            sortCode.Text = Convert.ToString(sortCode1);



                            break;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // email.Text = ex.ToString();
            }
            //DateTime dt = DateTime.Today;

            //string connString = DBConnection.ConnectionString;

            //using (SqlConnection conn = new SqlConnection(connString))

            //{
            //    string query = "INSERT into tblTransaction (TransactionName, TransactionDate, PaymentTotal, TransactionTypeID, FromAccount, ToAccount) values (@transactionName, @transactionDate, @paymentTotal, @transactionTypeID, @fromAccount, @toAccount);";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@transactionName", reference.Value);
            //    cmd.Parameters.AddWithValue("@transactionDate", dt);
            //    cmd.Parameters.AddWithValue("@paymentTotal", amount.Value);
            //    cmd.Parameters.AddWithValue("@transactionTypeID", 3);
            //    cmd.Parameters.AddWithValue("@fromAccount", Session["id"]);
            //    cmd.Parameters.AddWithValue("@toAccount", accountNo.Value);


            //    cmd.Connection.Open();
            //    try
            //    {
            //        cmd.ExecuteNonQuery();
            //        lblMessage.Text = "Payment made successfully";
            //    }
            //    catch (Exception ex)
            //    {
            //        lblMessage.Text = Convert.ToString(ex);
            //        throw new Exception("Error " + ex.Message);
            //    }
            //}





            balanceLabel.Text = "£" + Convert.ToString(ba.getBalance());

            double x = ba.getBalance();

            if (x < 0)
            {

                availableLabel.Text = "£0";
                chargesLabel.Text = "£" + Convert.ToString(ba.setInterest());
            }

            else
            {
                availableLabel.Text = "£" + Convert.ToString(ba.getBalance());
                chargesLabel.Text = "£0";
            }

            overdraftLimit.Text = "£" + Convert.ToString(ba.getOverdraftLimit());
        }
    }




    public static double getx()
    {

        return displayBalance;
    }

    protected void withdraw_Click(object sender, EventArgs e)
    {
        ba.setWithdraw(Convert.ToDouble(TextBox1.Text));
        balanceLabel.Text = "£" + Convert.ToString(ba.getBalance());
    }




    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
}