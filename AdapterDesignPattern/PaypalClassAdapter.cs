using System;

namespace AdapterDesignPattern
{
    internal class PaypalClassAdapter : PaypalService, IPaymentGateway
    {
        private readonly string _accountEmail;

        public PaypalClassAdapter(string accountEmail)
        {
            _accountEmail = accountEmail;
        }

        public void MakePayment(int amount)
        {
            ProcessTransaction(_accountEmail, amount);
        }
    }
}
