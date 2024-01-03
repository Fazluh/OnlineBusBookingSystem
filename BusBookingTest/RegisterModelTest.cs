using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
using OnlineBusBookingSystem.Models;

namespace BusBookingTesting
{
    [TestFixture]
    public class RegisterModelTests
    {
        [Test]
        public void Name_RequiredAttribute()
        {
            // Arrange
            var model = new RegisterModel();

            // Act
            var result = ValidateModel(model, "Name");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void UserName_RequiredAttribute()
        {
            // Arrange
            var model = new RegisterModel();

            // Act
            var result = ValidateModel(model, "UserName");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Password_RequiredAttribute()
        {
            // Arrange
            var model = new RegisterModel();

            // Act
            var result = ValidateModel(model, "Password");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Password_ValidRegularExpression()
        {
            // Arrange
            var model = new RegisterModel
            {
                Password = "ValidPassword1$"
            };

            // Act
            var result = ValidateModel(model, "Password");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ConfirmPassword_RequiredAttribute()
        {
            // Arrange
            var model = new RegisterModel();

            // Act
            var result = ValidateModel(model, "ConfirmPassword");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ConfirmPassword_MatchesPassword()
        {
            // Arrange
            var model = new RegisterModel
            {
                Password = "Password123$",
                ConfirmPassword = "Password123$"
            };

            // Act
            var result = ValidateModel(model, "ConfirmPassword");

            // Assert
            Assert.IsTrue(result);
        }

        private bool ValidateModel(object model, string propertyName)
        {
            var context = new ValidationContext(model, null, null)
            {
                MemberName = propertyName
            };
            var results = new List<ValidationResult>();
            return Validator.TryValidateProperty(model.GetType().GetProperty(propertyName).GetValue(model), context, results);
        }
    }
}
