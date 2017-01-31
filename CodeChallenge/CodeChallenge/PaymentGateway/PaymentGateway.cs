using CodeChallenge.IPaymentGateway;
using System;

namespace CodeChallenge.PaymentGateway
{
    public class PaymentGateway : IPaymentGateway.IPaymentGateway, IDisposable
    {
        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
