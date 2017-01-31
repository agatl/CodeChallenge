using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class ProcessOrders
    {   
        public bool isInventoryExists,paymentStatus;
        private IPaymentGateway.IPaymentGateway paymentGateway=new PaymentGateway.PaymentGateway();
        public ProcessOrders(string productId, int qty)
        {
            this.isInventoryExists = CheckInventory(productId, qty);
        }
        private bool CheckInventory(string productId, int qty) {   
        return true;
        }
        public bool PlaceAnOrder(string prodId,int prodQty) {
        try {
                paymentStatus=paymentGateway.ChargePayment("1234567891", 1.23m);
                return paymentStatus;
        }
        catch(Exception ex) {
                throw;
        }
        }
            

    }
}
