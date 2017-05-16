using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Statement : System.Web.UI.Page 
{

        static double x = 50;
        CurrentAccount ba = new CurrentAccount(x);


    StudentAccount st = new StudentAccount();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }

        ////

        ba.setWithdraw(500);

        balanceLabel.Text = "£" + Convert.ToString(ba.getBalance());

        double x = ba.getBalance();

        if (x < 0)
        {

            availableLabel.Text = "£0";
            chargesLabel.Text = "£" + Convert.ToString(ba.setInterest());
        }

        else
        {
            availableLabel.Text = "£" + Convert.ToString(ba.getBalance());
            chargesLabel.Text = "£0";
        }

        overdraftLimit.Text = "£" + Convert.ToString(ba.getOverdraftLimit());
    }

    


    
            public static double getx() {

            return x;
        }
        

}