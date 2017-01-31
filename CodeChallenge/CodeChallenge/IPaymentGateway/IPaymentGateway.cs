using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.IPaymentGateway
{
    public interface IPaymentGateway : IDisposable
    {
        bool ChargePayment(string creditCardNumber, decimal amount);
    }
}
