using System;
using System.Collections.Generic;
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
        string userName1, password1;
        userName1 = userName.Value;
        password1 = password.Value;

        string strcon = DBConnection.ConnectionString;
        // string strcon = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=D:\\Lukasz\\programming\\Online Banking website\\App_Data\\BankingData.mdf;Integrated Security = True";
        //string strcon = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\MTSheikh\\Desktop\\BankingWebsite\\App_Data\\BankingData.mdf;Integrated Security = True";
        // string strcon = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Yasar\\Documents\\Visual Studio 2015\\Projects\\New folder\\BankingWebsite\\App_Data\\BankingData.mdf;Integrated Security=True";
        // string strcon = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alam\\Documents\\Banking_Project\\App_Data\\BankingData.mdf;Integrated Security=True";

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("CUser", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;
        SqlParameter p1 = new SqlParameter("email", userName1);
        SqlParameter p2 = new SqlParameter("password", password1);
        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        con.Open();

        //SqlDataAdapter sda = new SqlDataAdapter(com);
        SqlDataReader rd = com.ExecuteReader();
        //DataTable dt = new DataTable();
        //sda.Fill(dt);
        //con.Open();
        //int i = com.ExecuteNonQuery();
        //con.Close();

        if (rd.HasRows)
        {
            rd.Read();

            Label1.Visible = true;
              Label1.Text = "Login successful";
            Session["id"] = userName.Value;
            Response.Redirect("WelcomePage.aspx");
            Session.RemoveAll();
        }
        else
        {
            Label1.Text = "You're username and word is incorrect";
            Label1.ForeColor = System.Drawing.Color.Red;

            //dc
        }


        
      
        //SqlDataReader rd = com.ExecuteReader();
        //if (rd.HasRows)
        //{
        //    rd.Read();

        //    //Label3.Visible = true;
        //  //  Label1.Text = "Login successful";
        //    Response.Redirect("WelcomePage.aspx");
        //}
        //else
        //{
        //    //Label3.Text = "Invalid username or password.";
        //    //Label3.Visible = true;
        //    Label1.Text = "Invalid username or password";

        //    //dc
        //}
    }
}