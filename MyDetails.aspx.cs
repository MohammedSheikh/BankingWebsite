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
            pullData();
        }
    }

    public void pullData()
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
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connString = DBConnection.ConnectionString;
        using (SqlConnection conn = new SqlConnection(connString))

        {
            string query = "UPDATE Customer SET AddressOne = @address1, AddressTwo = @address2, AddressThree = @address3, PostCode = @postcode, HomePhone = @homePhone, Mobile = @mobile, Email = @email  where CustomerID =" + Session["id"];
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@address1", Address1.Text);
            cmd.Parameters.AddWithValue("@address2", Address2.Text);
            cmd.Parameters.AddWithValue("@address3", Address3.Text);
            cmd.Parameters.AddWithValue("@postcode", PostCode.Text);
            cmd.Parameters.AddWithValue("@homePhone", homePhone.Text);
            cmd.Parameters.AddWithValue("@mobile", mobile.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
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