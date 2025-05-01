
using System;

namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using object adapter poattern
            Console.WriteLine("Using Object Adapter pattern");
            IPaymentGateway paymentGateway = new PaypalObjectAdapter("user@example.com");
            paymentGateway.MakePayment(1000);
            Console.WriteLine();


            //using class adapter pattern
            Console.WriteLine("Using Class Adapter pattern");
            IPaymentGateway payment = new PaypalClassAdapter("user@example.com");
            payment.MakePayment(1000);
            Console.ReadLine();
        }
    }
}
