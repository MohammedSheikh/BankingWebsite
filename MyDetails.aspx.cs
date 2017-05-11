using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            updateChanges();
        }



        //Address1.Text =("Ram");
        //Address2.Text = ("Ram");
        //Address3.Text = ("Ram");
        //PostCode.Text = ("Ram");
        //homePhone.Text = ("Ram");
        //mobile.Text = ("Ram");
        //email.Text = ("Ram");

    }

    public void updateChanges()
    {


        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
        else
        {

            string addressOne = null;
            int homePhone1 = 0;
            string addressTwo = null;
            string addressThree = null;
            string postCode = null;
            int mobile1 = 0;
            string email1 = null;
            Boolean j = true;

            try
            {


                string sql = "SELECT AddressOne, AddressTwo, AddressThree, HomePhone, PostCode, Mobile, Email FROM Customer where CustomerID =" + Session["id"];
                //change this connection string... visit www.connectionstrings.com
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
                            // homePhone1 = Convert.ToInt32(reader[0]);

                            //name = reader[0] as string;
                            // lastName1 = reader[0] as string;
                            //break for single row or you can continue if you have multiple rows...
                            addressOne = reader["AddressOne"].ToString();
                            addressTwo = reader["AddressTwo"].ToString();
                            addressThree = reader["AddressThree"].ToString();
                            homePhone1 = Convert.ToInt32(reader["HomePhone"]);
                            postCode = reader["PostCode"].ToString();
                            mobile1 = Convert.ToInt32(reader["Mobile"]);
                            email1 = reader["Email"].ToString();


                            Address1.Text = addressOne;
                            Address2.Text = addressTwo;
                            Address3.Text = addressThree;
                            homePhone.Text = Convert.ToString(homePhone1);
                            PostCode.Text = postCode;
                            mobile.Text = Convert.ToString(mobile1);
                            email.Text = email1;


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
        }
        //string address1 = null;
        //Address1.Text = address1;
        //string connString;
        //SqlConnection connection;
        //connString = DBConnection.ConnectionString;
        //connection = new SqlConnection(connString);
        //connection.Open();
        //SqlCommand command;
        //SqlDataAdapter adapter = new SqlDataAdapter();
        //String sql = "";
        //sql = "Update Customer set AddressOne = @address1 where CustomerID =" + Session["id"];
        //adapter.UpdateCommand = new SqlCommand(sql, connection);
        //command = new SqlCommand(sql, connection);
        //command.Parameters.AddWithValue("@address1", Address1.Text);
        //adapter.UpdateCommand.ExecuteNonQuery();
        //command.Dispose();
        //connection.Close();


    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        string connString = DBConnection.ConnectionString;
        using (SqlConnection conn = new SqlConnection(connString))

        {

            string query = "UPDATE Customer SET AddressOne = @address1  where CustomerID =" + Session["id"];
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@address1", Address1.Text);
            //cmd.Parameters.AddWithValue("@Name", txtName.Text);
            //cmd.Parameters.AddWithValue("@Category", Category.Text);
            //cmd.Parameters.AddWithValue("@start", txtStart.Text);
            //cmd.Parameters.AddWithValue("@end", txtend.Text);
            //cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }

        }
    }
}