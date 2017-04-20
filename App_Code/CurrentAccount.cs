using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CurrentAccount
/// </summary>
public class CurrentAccount: BankAccount
{
    public CurrentAccount(double startBalance) : base(balance)
    {
        balance = startBalance;
    }


}