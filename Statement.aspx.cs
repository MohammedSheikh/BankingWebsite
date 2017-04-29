using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Statement : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CurrentAccount ba = new CurrentAccount(200);

        ba.setWithdraw(600);

        balanceLabel.Text = "£" + Convert.ToString(ba.getBalance());

        double x = ba.getAvailableBalance();

        if (x < 0)
        {

            availableLabel.Text = "£0";
        }

        else
        {
            availableLabel.Text = "£" + Convert.ToString(ba.getAvailableBalance());

        }

        overdraftLimit.Text = "£" + Convert.ToString(ba.getOverdraftLimit());
        chargesLabel.Text = "£" + Convert.ToString(ba.setInterest());
    }

}