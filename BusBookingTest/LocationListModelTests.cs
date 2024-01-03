using NUnit.Framework;
using OnlineBusBookingSystem.Models;

[TestFixture]
public class LocationListModelTests
{
    [Test]
    public void LocationListModel_SetAndGetLocationId()
    {
        // Arrange
        LocationListModel location = new LocationListModel();
        int expectedLocationId = 1;

        // Act
        location.LocationId = expectedLocationId;
        int actualLocationId = location.LocationId;

        // Assert
        Assert.AreEqual(expectedLocationId, actualLocationId);
    }

    [Test]
    public void LocationListModel_SetAndGetMappingTerminal()
    {
        // Arrange
        LocationListModel location = new LocationListModel();
        string expectedTerminal = "North Terminal";

        // Act
        location.Terminal = expectedTerminal;
        string actualTerminal = location.Terminal;

        // Assert
        Assert.AreEqual(expectedTerminal, actualTerminal);
    }

    [Test]
    public void LocationListModel_SetAndGetCity()
    {
        // Arrange
        LocationListModel location = new LocationListModel();
        string expectedCity = "North City";

        // Act
        location.City = expectedCity;
        string actualCity = location.City;

        // Assert
        Assert.AreEqual(expectedCity, actualCity);
    }

    [Test]
    public void LocationListModel_SetAndGetState()
    {
        // Arrange
        LocationListModel location = new LocationListModel();
        string expectedState = "Test Only";

        // Act
        location.State = expectedState;
        string actualState = location.State;

        // Assert
        Assert.AreEqual(expectedState, actualState);
    }
}

