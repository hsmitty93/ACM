using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var orderItem = new OrderItem()
            {
                PurchasePrice = 10,
                Quantity = 1,
                ProductId = 1
            };

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidatePurchasePriceMissing()
        {
            //--Arrange
            var orderItem = new OrderItem()
            {
                Quantity = 1,
                ProductId = 1
            };

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateQuantityInvalid()
        {
            //--Arrange
            var orderItem = new OrderItem()
            {
                PurchasePrice = 10,
                Quantity = -6,
                ProductId = 1
            };

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateProductIdInvalid()
        {
            //--Arrange
            var orderItem = new OrderItem()
            {
                PurchasePrice = 10,
                Quantity = 1,
                ProductId = -1
            };

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.AreEqual(false, actual);
        }
    }
}