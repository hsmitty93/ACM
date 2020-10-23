using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTests
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //--Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //--Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void InsertSpacesTestNoUpperCases()
        {
            //--Arrange
            var source = "sonicscrewdriver";
            var expected = "sonicscrewdriver";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void InsertSpacesTestsEmptyString()
        {
            //--Arrange
            var source = "";
            var expected = "";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual); 
        }
    }
}
