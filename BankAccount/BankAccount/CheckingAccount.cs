using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class CheckingAccount:Bankaccount
    {
        public CheckingAccount(string accountHolder, decimal balance) : base(accountHolder, balance) { }

        public override void CalculateInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest.");
        }
    }
}
