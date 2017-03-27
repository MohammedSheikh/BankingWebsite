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
        string firstName1, surName1, gender1, mStatus1, dob1, cob1, nationality1, postcode1, houseno1, phoneno1, email1;
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

        DB_Handler.saveUser(firstName1, surName1, gender1, mStatus1, dob1, cob1, nationality1, postcode1, houseno1, phoneno1, email1);
    }
}