using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using ACM.BL;
using System.Collections.Generic;

namespace Acme.CommonTests
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //--Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "hsmitty@gmail.com",
                FirstName = "Hailey",
                LastName = "Smith",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(1)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            //--Act
            LoggingService.WriteToFile(changedItems);

            //--Assert
            //Nothing here to assert, maybe change something in order to get something to assert against
        }
    }
}