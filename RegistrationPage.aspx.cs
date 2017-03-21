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
        string firstName1 = firstName.Value;
        string surName1 = surName.Value;
        DB_Handler.saveUser(firstName1, surName1);
    }
}