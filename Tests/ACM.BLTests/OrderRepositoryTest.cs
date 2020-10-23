using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var repo = new OrderRepository();
            var expected = new Order(1){
                OrderDate = new DateTimeOffset(2020, 10, 10, 12, 23, 04, TimeSpan.Zero)
            };

            var actual = repo.Retrieve(1);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
        [TestMethod]
        public void SaveValid()
        {
            var orderRepo = new OrderRepository();
            var updatedOrder = new Order(1)
            {
                OrderDate = new DateTimeOffset(2020, 11, 10, 12, 23, 04, TimeSpan.Zero),
                HasChanges = true
            };

            var actual = orderRepo.Save(updatedOrder);

            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveInvalid()
        {
            var orderRepo = new OrderRepository();
            var updatedOrder = new Order(1)
            {
                OrderDate = null,
                HasChanges = true
            };

            var actual = orderRepo.Save(updatedOrder);

            Assert.AreEqual(false, actual);
        }
    }
}