using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoggedIn : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void okButton_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("LoginPage.aspx");
    }

    protected void cancelButton_Click(object sender, EventArgs e)
    {
        //do nothing
    }
}
