using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BankAccount
/// </summary>
public class BankAccount
{
    protected static double initialBalance;
    protected double deposit;
    protected double withdrawal;
  

    protected BankAccount(double balance)
    {
        initialBalance = balance;
    }

    protected void setDeposit(double amount)
    {
        initialBalance += amount;
        deposit += amount;
    }


    protected double getDeposit()
    {
        return deposit;
    }


    protected void setWithdraw(double amount)
    {
        initialBalance -= amount;
        withdrawal += amount;
    }

    protected double getWithdraw()
    {
        return withdrawal;
    }

    protected double getBalance()
    {
        return initialBalance;
    }
}