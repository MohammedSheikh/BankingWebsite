using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BankAccount
/// </summary>
public class BankAccount
{
    protected static double balance;
    protected double deposit;
    protected double withdrawl;
  

    protected BankAccount(double bbalance)
    {
        bbalance = balance;
        
    }

    protected void setDeposit(double amount)
    {
        balance += amount;
        deposit += amount;
    }
    protected double getDeposit()
    {
        return deposit;
    }
    protected void setWithdraw(double amount)
    {
        balance -= amount;
        withdrawl += amount;
    }
    protected double getWithdraw()
    {
        return withdrawl;
    }
    protected double getBalance()
    {
        return balance;
    }
}