using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class SavingsAccount:Bankaccount
    {
        public SavingsAccount(string accountHolder, decimal balance) : base(accountHolder, balance) { }

    public override void CalculateInterest()
    {
        decimal interest = Balance * 0.05m;
        Console.WriteLine($"Interest for {AccountHolder}'s savings account: {interest}");
    }
    }
}
