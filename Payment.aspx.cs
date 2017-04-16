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

    }

    protected void btnPayment_Click(object sender, EventArgs e)
    {

//        CREATE PROCEDURE[dbo].[Payment]

//    @transactionName VARCHAR(50) ,
//    @transactionDate VARCHAR(50)  ,
//    @paymentTotal VARCHAR(50) ,
//    @transactionTypeID DATE,
//    @from  int,
//	@to int


//AS

//    insert into Transaction values(@transactionName, @transactionDate, @paymentTotal, @transactionTypeID, @from, @to)


        string strcon = DBConnection.ConnectionString;

        //todays date
        DateTime dt = DateTime.Today;

        //Also need auto-generated accountTypeID
        //need sproc for payment

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("Payment", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("title", accountNo.Value);
        SqlParameter p2 = new SqlParameter("firstName", sortCode.Value);
        SqlParameter p3 = new SqlParameter("lastName", reference.Value);
        SqlParameter p4 = new SqlParameter("gender", amount.Value);
        //auto generated date
        SqlParameter p5 = new SqlParameter("gender", dt);

        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        com.Parameters.Add(p3);
        com.Parameters.Add(p4);

        con.Open();
        SqlDataReader rd = com.ExecuteReader();
        if (rd.HasRows)
        {
            rd.Read();
            lblMessage.Text = "Paid";
            lblMessage.Visible = true;
        }
        else
        {
            lblMessage.Text = "Payment Failed";
            lblMessage.Visible = true;
        }
    }
}
