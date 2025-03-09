using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Bankaccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public Bankaccount(string accountHolder, decimal balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public virtual void CalculateInterest()
        {
            
        }
    }
}
