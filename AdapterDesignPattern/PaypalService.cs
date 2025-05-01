using System;

namespace AdapterDesignPattern
{
    //This is the third party which is incompatoble with our service for example:)
    internal class PaypalService
    {
        public void ProcessTransaction(string accountEmail, int amount)
        {
            Console.WriteLine($"Processing ${amount} payment through PayPal for account: {accountEmail}");
        }
    }
}
