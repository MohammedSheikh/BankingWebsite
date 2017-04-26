using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CurrentAccount
/// </summary>
public class CurrentAccount: BankAccount
{
    double interest;

    public CurrentAccount(double startBalance) : base(initialBalance)
    {
        initialBalance = startBalance;
    }

    public double setInterest()
    {

        return interest = initialBalance * 0.02 * 12;
        
    }

     public new double getBalance()
    {
        return initialBalance + interest;
    }
}