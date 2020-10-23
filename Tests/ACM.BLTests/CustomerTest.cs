using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Smith",
                FirstName = "Hailey"
            };

            //--Act
            var actual = customer.FullName;

            //--Assert
            Assert.AreEqual("Smith, Hailey", actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Smith"
            };

            //--Act
            var actual = customer.FullName;

            //--Assert
            Assert.AreEqual("Smith", actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Hailey"
            };

            //--Act
            var actual = customer.FullName;

            //--Assert
            Assert.AreEqual("Hailey", actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            Customer c1 = new Customer
            {
                FirstName = "Hailey"
            };
            Customer.InstanceCount += 1;

            Customer c2 = new Customer
            {
                FirstName = "Frank"
            };
            Customer.InstanceCount += 1;

            Customer c3 = new Customer
            {
                FirstName = "Steve"
            };
            Customer.InstanceCount += 1;

            //--Act

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Smith",
                EmailAddress = "hsmitty@gmail.com"
            };

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Smith"
            };

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer
            {
                EmailAddress = "hsmitty@gmail.com"
            };

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(false, actual);
        }

    }
}