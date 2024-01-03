using NUnit.Framework;
using OnlineBusBookingSystem.Models;

[TestFixture]
public class InvalidEmailOrPasswordExceptionTests
{

    [Test]
    public void InvalidEmailOrPasswordException_MessageConstructor()
    {
        // Arrange
        string errorMessage = "Invalid email or password.";

        // Act
        InvalidEmailOrPasswordException exception = new InvalidEmailOrPasswordException(errorMessage);

        // Assert
        Assert.IsNotNull(exception);
        Assert.IsInstanceOf<InvalidEmailOrPasswordException>(exception);
        Assert.IsNull(exception.InnerException);
        Assert.AreEqual(errorMessage, exception.Message);
    }

    [Test]
    public void InvalidEmailOrPasswordException_InnerExceptionConstructor()
    {
        // Arrange
        string errorMessage = "Invalid email or password.";
        Exception innerException = new Exception("Inner exception message.");

        // Act
        InvalidEmailOrPasswordException exception = new InvalidEmailOrPasswordException(errorMessage, innerException);

        // Assert
        Assert.IsNotNull(exception);
        Assert.IsInstanceOf<InvalidEmailOrPasswordException>(exception);
        Assert.IsNotNull(exception.InnerException);
        Assert.AreEqual(innerException, exception.InnerException);
        Assert.AreEqual(errorMessage, exception.Message);
    }

}
