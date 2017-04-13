using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object Source, EventArgs e)
    {

        //string strcon = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\MTSheikh\\Desktop\\BankingWebsite\\App_Data\\BankingData.mdf;Integrated Security = True";
        string strcon = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=D:\\Lukasz\\programming\\Online Banking website\\App_Data\\BankingData.mdf;Integrated Security = True";

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("registration", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("title", title.Value);
        SqlParameter p2 = new SqlParameter("firstName", firstName.Value);
        SqlParameter p3 = new SqlParameter("lastName", surName.Value);
        SqlParameter p4 = new SqlParameter("gender", gender.Value);
        SqlParameter p5 = new SqlParameter("maritalStatus", mStatus.Value);
        SqlParameter p6 = new SqlParameter("dOB", dob.Value);
        SqlParameter p7 = new SqlParameter("birthCountry", cob.Value);
        SqlParameter p8 = new SqlParameter("nationality", nationality.Value);
        SqlParameter p9 = new SqlParameter("addressOne", houseNO.Value);
        SqlParameter p10 = new SqlParameter("addressTwo", addressLine2.Value);
        SqlParameter p11 = new SqlParameter("addressThree", addressLine3.Value);
        SqlParameter p12 = new SqlParameter("city", city.Value);
        SqlParameter p13 = new SqlParameter("county", county.Value);
        SqlParameter p14 = new SqlParameter("country", country.Value);
        SqlParameter p15  = new SqlParameter("postCode", postCode.Value);
        SqlParameter p16 = new SqlParameter("homePhone", phoneNo.Value);
        SqlParameter p17 = new SqlParameter("mobile", mobile.Value);
        SqlParameter p18 = new SqlParameter("email", email.Value);
        SqlParameter p19 = new SqlParameter("password", password.Value);
        SqlParameter p20 = new SqlParameter("joinedDate", joinedDate.Value);
       

        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        com.Parameters.Add(p3);
        com.Parameters.Add(p4);
        com.Parameters.Add(p5);
        com.Parameters.Add(p6);
        com.Parameters.Add(p7);
        com.Parameters.Add(p8);
        com.Parameters.Add(p9);
        com.Parameters.Add(p10);
        com.Parameters.Add(p11);
        com.Parameters.Add(p12);
        com.Parameters.Add(p13);
        com.Parameters.Add(p14);
        com.Parameters.Add(p15);
        com.Parameters.Add(p16);
        com.Parameters.Add(p17);
        com.Parameters.Add(p18);
        com.Parameters.Add(p19);
        com.Parameters.Add(p20);



        con.Open();
        SqlDataReader rd = com.ExecuteReader();
        if (rd.HasRows)
        {
            rd.Read();
            errorLabel.Text = "Regsitered.";
            errorLabel.Visible = true;
        }
        else
        {
            errorLabel.Text = "Wrong.";
            errorLabel.Visible = true;
        }

        //string title1, firstName1, surName1, gender1, mStatus1, dob1, cob1, nationality1, postcode1, houseno1, phoneno1, email1, addressline_2, addressline_3, city1, county1, country1, joinedDate1, mobile1;
        //title1 = title.Value;
        //firstName1 = firstName.Value;
        //surName1 = surName.Value;
        //gender1 = gender.Value;
        //mStatus1 = mStatus.Value;
        //dob1 = dob.Value;
        //cob1 = cob.Value;
        //nationality1 = nationality.Value;
        //postcode1 = postCode.Value;
        //houseno1 = houseNO.Value;
        //phoneno1 = phoneNo.Value;
        //email1 = email.Value;
        //addressline_2 = addressLine2.Value;
        //addressline_3 = addressLine3.Value;
        //city1 = city.Value;
        //county1 = county.Value;
        //country1 = country.Value;
        //joinedDate1 = joinedDate.Value;
        //mobile1 = mobile.Value;

        //DB_Handler.saveUser(title1, firstName1, surName1, gender1, mStatus1, dob1, cob1, nationality1, postcode1, houseno1, phoneno1, email1, addressline_2, addressline_3, city1, county1, country1, joinedDate1, mobile1);
    }



    protected void TEST1_Click(object sender, EventArgs e)
    {
        //string strcon = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\MTSheikh\\Desktop\\BankingWebsite\\App_Data\\BankingData.mdf;Integrated Security = True";
        string strcon = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=D:\\Lukasz\\programming\\Online Banking website\\App_Data\\BankingData.mdf;Integrated Security = True";

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("registration", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("title", title.Value);
        SqlParameter p2 = new SqlParameter("firstName", firstName.Value);
        SqlParameter p3 = new SqlParameter("lastName", surName.Value);
        SqlParameter p4 = new SqlParameter("gender", gender.Value);
        SqlParameter p5 = new SqlParameter("maritalStatus", mStatus.Value);
        SqlParameter p6 = new SqlParameter("dOB", dob.Value);
        SqlParameter p7 = new SqlParameter("birthCountry", cob.Value);
        SqlParameter p8 = new SqlParameter("nationality", nationality.Value);
        SqlParameter p9 = new SqlParameter("addressOne", houseNO.Value);
        SqlParameter p10 = new SqlParameter("addressTwo", addressLine2.Value);
        SqlParameter p11 = new SqlParameter("addressThree", addressLine3.Value);
        SqlParameter p12 = new SqlParameter("city", city.Value);
        SqlParameter p13 = new SqlParameter("county", county.Value);
        SqlParameter p14 = new SqlParameter("country", country.Value);
        SqlParameter p15 = new SqlParameter("postCode", postCode.Value);
        SqlParameter p16 = new SqlParameter("homePhone", phoneNo.Value);
        SqlParameter p17 = new SqlParameter("mobile", mobile.Value);
        SqlParameter p18 = new SqlParameter("email", email.Value);
        SqlParameter p19 = new SqlParameter("password", password.Value);
        SqlParameter p20 = new SqlParameter("joinedDate", joinedDate.Value);


        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        com.Parameters.Add(p3);
        com.Parameters.Add(p4);
        com.Parameters.Add(p5);
        com.Parameters.Add(p6);
        com.Parameters.Add(p7);
        com.Parameters.Add(p8);
        com.Parameters.Add(p9);
        com.Parameters.Add(p10);
        com.Parameters.Add(p11);
        com.Parameters.Add(p12);
        com.Parameters.Add(p13);
        com.Parameters.Add(p14);
        com.Parameters.Add(p15);
        com.Parameters.Add(p16);
        com.Parameters.Add(p17);
        com.Parameters.Add(p18);
        com.Parameters.Add(p19);
        com.Parameters.Add(p20);



        con.Open();
        SqlDataReader rd = com.ExecuteReader();
        if (rd.HasRows)
        {
            rd.Read();
            errorLabel.Text = "Regsitered.";
            errorLabel.Visible = true;
        }
        else
        {
            errorLabel.Text = "Wrong.";
            errorLabel.Visible = true;
        }
    }
}