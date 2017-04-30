using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }

        Address1.Text =("Ram");
        Address2.Text = ("Ram");
        Address3.Text = ("Ram");
        PostCode.Text = ("Ram");
        homePhone.Text = ("Ram");
        mobile.Text = ("Ram");
        email.Text = ("Ram");
        
    }

    protected void textCheck(object sender, EventArgs e)
    {
        saveChangesButton.Enabled = !String.IsNullOrEmpty(Address1.Text);

    }

    protected void textCheck2(object sender, EventArgs e)
    {
        saveChangesButton.Enabled = !String.IsNullOrEmpty(Address2.Text);

    }

    protected void textCheck3(object sender, EventArgs e)
    {
        saveChangesButton.Enabled = !String.IsNullOrEmpty(Address3.Text);

    }

    protected void textCheck4(object sender, EventArgs e)
    {
        saveChangesButton.Enabled = !String.IsNullOrEmpty(PostCode.Text);

    }

    protected void textCheck5(object sender, EventArgs e)
    {
        saveChangesButton.Enabled = !String.IsNullOrEmpty(homePhone.Text);

    }

    protected void textCheck6(object sender, EventArgs e)
    {
        saveChangesButton.Enabled = !String.IsNullOrEmpty(mobile.Text);

    }

    protected void textCheck7(object sender, EventArgs e)
    {
        saveChangesButton.Enabled = !String.IsNullOrEmpty(email.Text);

    }
}