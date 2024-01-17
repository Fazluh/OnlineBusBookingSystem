using OnlineBusBookingSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace BusBookingTesting
{


    [TestFixture]
    public class LoginModelTests
    {
        [Test]
        public void LoginModel_Properties()
        {
            // Arrange
            var model = new LoginModel
            {
                Id = 3,
                Name = "Pallavi",
                UserName = "Pallavi",
                Password = "Fazal123@",
                Role = "user"
            };
            // Act & Assert
            Assert.AreEqual(3, model.Id);
            Assert.AreEqual("Pallavi", model.Name);
            Assert.AreEqual("Pallavi", model.UserName);
            Assert.AreEqual("Fazal123@", model.Password);
            Assert.AreEqual("user", model.Role);
        }

        [Test]
        public void LoginModel_UserName_Required()
        {
            // Arrange
            var model = new LoginModel();

            //Act
            var context = new ValidationContext(model, null, null);
            var result = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(model, context, result, true);


            //Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("The UserName field is required.", result[0].ErrorMessage);
        }

        [Test]
        public void LoginModel_Password_Required()
        {
            // Arrange
            var model = new LoginModel();

            //Act
            var context = new ValidationContext(model, null, null);
            var result = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(model, context, result, true);

            //Arrange
            Assert.IsFalse(isValid);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("The UserName field is required.", result[0].ErrorMessage);
        }

        // Add more test cases for validation, if needed
    }
}
