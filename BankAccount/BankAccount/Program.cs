using BankAccount;
using System;

class Program
{
    static void Main()
    {
        Bankaccount savings = new SavingsAccount("Ahmet", 1000m);
        Bankaccount checking = new CheckingAccount("Mehmet", 1500m);

        savings.CalculateInterest();
        checking.CalculateInterest();
    }
}