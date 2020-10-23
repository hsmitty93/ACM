using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid(){
            //--Arrange
            var repo = new CustomerRepository();
            var expected = new Customer(1) {
                EmailAddress = "hsmitty@gmail.com",
                FirstName = "Hailey",
                LastName = "Smith"
            };

            //--Act
            var actual = repo.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepo = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "hsmitty@gmail.com",
                FirstName = "Hailey",
                LastName = "Smith",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };

            var actual = customerRepo.Retrieve(1);

            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }

        [TestMethod]
        public void SaveValid()
        {
            var customerRepo = new CustomerRepository();
            var updatedCustomer = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                EmailAddress = "bilbo@baggins.com",
                HasChanges = true
            };

            var actual = customerRepo.Save(updatedCustomer);

            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveInvalid()
        {
            var customerRepo = new CustomerRepository();
            var updatedCustomer = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "",
                EmailAddress = "bilbo@baggins.com",
                HasChanges = true
            };

            var actual = customerRepo.Save(updatedCustomer);

            Assert.AreEqual(false, actual);
        }
    }
}