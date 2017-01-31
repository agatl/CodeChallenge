using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge;

namespace Console_CodeChallanege
{
    static class Program
    {
        public static string prodId, prodQty;
        private static int value;
        public static bool paymentStatus;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Id:");
            prodId = Console.ReadLine();
            Console.WriteLine("Enter Quantity:");
            prodQty = Console.ReadLine();
            if (int.TryParse(prodId, out value) && int.TryParse(prodQty, out value))
            {
                StringBuilder prodIdBuilder = new StringBuilder();
                prodIdBuilder.Append("prod_");
                prodIdBuilder.Append(prodId);
                //Payment Gateway
                paymentStatus = ProcessAnOrder(prodIdBuilder);
                //Sent Shipping info about the order
                if (paymentStatus)
                {
                    Console.WriteLine("Payment Authorized");
                    Console.Read();
                    SendShippingDetails("acd@.com");
                    Console.Read();
                }

            }
        }

        private static void SendShippingDetails(string email)
        {
            Console.WriteLine("Email Sent Succesfully");
            Console.Read();
        }

        private static bool ProcessAnOrder(StringBuilder prodIdBuilder)
        {
            ProcessOrders processOrder = new CodeChallenge.ProcessOrders(prodIdBuilder.ToString(), Convert.ToInt32(prodQty));
            if (processOrder.isInventoryExists)
            {
                paymentStatus = processOrder.PlaceAnOrder(prodIdBuilder.ToString(), Convert.ToInt32(prodQty));

            }
            else
            {
                Console.WriteLine("Incorrect ProdId or Quantity");
                Console.Read();
            }
            return paymentStatus;
        }
    }
}
