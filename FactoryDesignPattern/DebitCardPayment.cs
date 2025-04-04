using FactoryDesignpattern;
using System;

namespace FactoryDesignPattern
{
    internal class DebitCardPayment: IPaymentType
    {
        public void ProcessPayment(int amount)
        {
            Console.WriteLine($"Rs.{amount} payment done through creditcard");
        }
    }
}
