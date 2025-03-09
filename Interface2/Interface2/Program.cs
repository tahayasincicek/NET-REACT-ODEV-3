// See httusing System;

using Interface2;

class Program
{
    static void Main()
    {
        IPaymentMethod creditCard = new CreditCard();
        IPaymentMethod bankTransfer = new BankTransfer();

        creditCard.ProcessPayment(100);
        bankTransfer.ProcessPayment(250);
    }
}
