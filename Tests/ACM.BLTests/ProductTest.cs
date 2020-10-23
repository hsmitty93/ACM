using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var product = new Product()
            {
                ProductName = "Chair",
                CurrentPrice = 10
            };

            //--Act
            var actual = product.Validate();

            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateMissingProductName()
        {
            //--Arrange
            var product = new Product()
            {
                CurrentPrice = 25
            };

            //--Act
            var actual = product.Validate();

            //--Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateMissingCurrentPrice()
        {
            //--Arrange
            var product = new Product()
            {
                ProductName = "Chair"
            };

            //--Act
            var actual = product.Validate();

            //--Assert
            Assert.AreEqual(false, actual);
        }
    }
}