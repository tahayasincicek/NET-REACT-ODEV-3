using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    public class CreditCard : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Payment of {amount} USD made using a credit card.");
        }
    }

}
