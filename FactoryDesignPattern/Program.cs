
using System;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select any payment method either credit card or debit card:");
            string paymentType=Console.ReadLine();
            var paymentFactory = PaymentFactory.GetPaymentTypeObject(paymentType);
            paymentFactory.ProcessPayment(1000);
            Console.ReadLine();
        }
    }
}
