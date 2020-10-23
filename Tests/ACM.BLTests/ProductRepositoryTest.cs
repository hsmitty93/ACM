using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var repo = new ProductRepository();
            var expected = new Product(1){
                ProductName = "Chair",
                ProductDescription = "Something you can sit on",
                CurrentPrice = 10
            };

            //--Act
            var actual = repo.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
        [TestMethod]
        public void SaveValid()
        {
            //--Arrange
            var productRepo = new ProductRepository();
            var updatedProduct = new Product(1)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set of 4 bright Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //--Act
            var actual = productRepo.Save(updatedProduct);

            //--Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveInvalid()
        {
            //--Arrange
            var productRepo = new ProductRepository();
            var updatedProduct = new Product(1)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set of 4 bright Sunflowers",
                ProductName = "",
                HasChanges = true
            };

            //--Act
            var actual = productRepo.Save(updatedProduct);

            //--Assert
            Assert.AreEqual(false, actual);
        }
    }
}