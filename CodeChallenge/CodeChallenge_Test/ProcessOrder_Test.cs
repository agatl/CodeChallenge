using CodeChallenge;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeChallenge_Test
{   
    [TestFixture]
   public class ProcessOrder_Test
    {
        public static string testString = "prod_32";
        public static int testQuantity = 1;
        ProcessOrders processOrderTest = new ProcessOrders(testString, testQuantity);

        [Test]
       public void IsInventoryExistsTest()
       {
            //Act
            bool isInventoryExistsExpected = processOrderTest.isInventoryExists;
            //Assert
            Assert.AreEqual(isInventoryExistsExpected, true);
       }
        [Test]
        public void PlaceAnOrderTest()
        {
            //Act
            bool isOrderPlacedExpected = processOrderTest.PlaceAnOrder(testString, testQuantity);
            //Assert
            Assert.AreEqual(isOrderPlacedExpected, true);
        }
    }
}
