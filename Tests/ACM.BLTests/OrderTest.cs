using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var order = new Order()
            {
                OrderDate = new DateTimeOffset(2020, 10, 10, 12, 23, 04, TimeSpan.Zero)
            };

            //--Act
            var actual = order.Validate();

            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateOrderDateMissing()
        {
            //--Arrange
            var order = new Order();

            //--Act
            var actual = order.Validate();

            //--Assert
            Assert.AreEqual(false, actual);
        }

    }
}