using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails_Review
{
    class BankAccount
    {
        private float balance;

    public BankAccount(float initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(float amount)
    {
        balance = balance + amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    public void Withdraw(float amount)
    {
        if (balance >= amount)
        {
            balance = balance - amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Balance: {balance}");
    }
}
}
