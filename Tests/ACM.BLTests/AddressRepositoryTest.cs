using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class AddressRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var repo = new AddressRepository();
            var expected = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "10012 NE 34th ST",
                StreetLine2 = "APT 292",
                City = "Ocean Shores",
                State = "Washington",
                Country = "United States",
                PostalCode = "98002"
            };

            var actual = repo.Retrieve(1);

            Assert.AreEqual(expected.AddressType, actual.AddressType);
            Assert.AreEqual(expected.StreetLine1, actual.StreetLine1);
            Assert.AreEqual(expected.StreetLine2, actual.StreetLine2);
            Assert.AreEqual(expected.City, actual.City);
            Assert.AreEqual(expected.State, actual.State);
            Assert.AreEqual(expected.Country, actual.Country);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);
        }
        [TestMethod]
        public void SaveValid()
        {
            var addressRepo = new AddressRepository();
            var updatedAddress = new Address(1)
            {
                AddressType = 2,
                StreetLine1 = "120 Goop ST",
                StreetLine2 = "#201",
                City = "Shoreline",
                PostalCode = "98007",
                HasChanges = true
            };

            var actual = addressRepo.Save(updatedAddress);

            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveInvalid()
        {
            var addressRepo = new AddressRepository();
            var updatedAddress = new Address(1)
            {
                AddressType = 2,
                StreetLine1 = "120 Goop ST",
                StreetLine2 = "#201",
                City = "Shoreline",
                PostalCode = null,
                HasChanges = true
            };

            var actual = addressRepo.Save(updatedAddress);

            Assert.AreEqual(false, actual);
        }
    }
}