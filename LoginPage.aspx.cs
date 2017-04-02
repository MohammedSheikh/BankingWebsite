using System;
using System.Collections.Generic;
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
        string strcon = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=D:\\Lukasz\\programming\\Online Banking website\\App_Data\\BankingData.mdf;Integrated Security = True";
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("CUser", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;
        SqlParameter p1 = new SqlParameter("email", userName1);
        SqlParameter p2 = new SqlParameter("password", password1);
        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        con.Open();
        SqlDataReader rd = com.ExecuteReader();
        if (rd.HasRows)
        {
            rd.Read();

            //Label3.Text = "Login successful.";
            //Label3.Visible = true;
            Label1.Text = "Login successful";
        }
        else
        {
            //Label3.Text = "Invalid username or password.";
            //Label3.Visible = true;
            Label1.Text = "DC FAM";
        }
    }
}