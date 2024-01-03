using NUnit.Framework;
using OnlineBusBookingSystem.Models;

namespace BusBookingTesting
{
    [TestFixture]
    public class BusListModelTests
    {
        [Test]
        public void BusListModel_Properties()
        {
            // Arrange
            var busModel = new BusListModel
            {
                BusNo = 1947,
                BusName = "Volvo Sleeper"
            };

            // Act - No specific action for properties

            // Assert
            Assert.AreEqual(1947, busModel.BusNo);
            Assert.AreEqual("Volvo Sleeper", busModel.BusName);
        }
    }
}
