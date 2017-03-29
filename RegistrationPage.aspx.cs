using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_OnClick(object Source, EventArgs e)
    {
        string title1, firstName1, surName1, gender1, mStatus1, dob1, cob1, nationality1, postcode1, houseno1, phoneno1, email1, addressline_2, addressline_3, city1, county1, country1, joinedDate1, mobile1;
        title1 = title.Value;
        firstName1 = firstName.Value;
        surName1 = surName.Value;
        gender1 = gender.Value;
        mStatus1 = mStatus.Value;
        dob1 = dob.Value;
        cob1 = cob.Value;
        nationality1 = nationality.Value;
        postcode1 = postCode.Value;
        houseno1 = houseNO.Value;
        phoneno1 = phoneNo.Value;
        email1 = email.Value;
        addressline_2 = addressLine2.Value;
        addressline_3 = addressLine3.Value;
        city1 = city.Value;
        county1 = county.Value;
        country1 = country.Value;
        joinedDate1 = joinedDate.Value;
        mobile1 = mobile.Value;

        DB_Handler.saveUser(title1, firstName1, surName1, gender1, mStatus1, dob1, cob1, nationality1, postcode1, houseno1, phoneno1, email1, addressline_2, addressline_3, city1, county1, country1, joinedDate1, mobile1);
    }


}