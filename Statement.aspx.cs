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
        BankAccount ba = new CurrentAccount(12.0);

        balanceLabel.Text = "£" + Convert.ToString(ba.getBalance());
        availableLabel.Text = "£" + Convert.ToString(ba.getAvailableBalance());
        overdraftLimit.Text = "£" + Convert.ToString(ba.getOverdraft());

    }

}