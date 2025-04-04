
using FactoryDesignpattern;

namespace FactoryDesignPattern
{
    public static class PaymentFactory
    {
        public static IPaymentType GetPaymentTypeObject(string paymentType) {
            switch(paymentType)
            {
                case "CreditCard":
                    return new CreditCardPayment();
                case "DebitCard":
                    return new DebitCardPayment();
                default:
                    throw new System.Exception("Wrong payment selected");
            }            
        }
    }
}
