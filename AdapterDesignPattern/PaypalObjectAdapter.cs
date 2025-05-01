
namespace AdapterDesignPattern
{
    //Using Object Adapter pattern
    internal class PaypalObjectAdapter : IPaymentGateway
    {
        private readonly PaypalService _paypalService;
        private readonly string _accountEmail;
        public PaypalObjectAdapter(string accountEmail)
        {
            _paypalService = new PaypalService();
            this._accountEmail = accountEmail;
        }

        public void MakePayment(int money)
        {
            _paypalService.ProcessTransaction(_accountEmail,money);
        }
    }
}
