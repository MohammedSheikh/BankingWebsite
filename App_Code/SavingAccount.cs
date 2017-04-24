using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SavingAccount
/// </summary>
public class SavingAccount: BankAccount
{
    private double annualInterestRate; 
    private double monthlyInterestRate;
    private double totalInterest;

    private SavingAccount(double startBalance, double annual_Interest_Rate) : base (balance)
    {
        
        balance = startBalance;
        annualInterestRate = annual_Interest_Rate;
    }

    private void calculateMonthlyInterest()
    {
        totalInterest = totalInterest + balance * monthlyInterestRate;
        balance = balance + balance * monthlyInterestRate;
    }

    private void setAnnualInterestRate(double annual_Interest_Rate)
    {
        monthlyInterestRate = annualInterestRate / 12;
    }



}