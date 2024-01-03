using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
using OnlineBusBookingSystem.Models;

namespace BusBookingTesting
{
    [TestFixture]
    public class BookedListModelTests
    {
        [Test]
        public void BusId_Should_Have_RangeAttribute()
        {
            // Arrange
            var model = new BookedListModel { BusId = 5000 };

            // Act
            var result = ValidateModel(model, "BusId");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ReferenceNo_Should_Have_RangeAttribute()
        {
            // Arrange
            var model = new BookedListModel { ReferenceNo = 1 };

            // Act
            var result = ValidateModel(model, "ReferenceNo");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void UserId_Should_Have_RequiredAttribute()
        {
            // Arrange
            var model = new BookedListModel { UserId = 2 };

            // Act
            var result = ValidateModel(model, "UserId");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Name_Should_Have_RequiredAttribute()
        {
            // Arrange
            var model = new BookedListModel { Name = "Bikram" };

            // Act
            var result = ValidateModel(model, "Name");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Qty_Should_Have_RangeAttribute()
        {
            // Arrange
            var model = new BookedListModel { Qty = 30 };

            // Act
            var result = ValidateModel(model, "Qty");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Amount_Should_Have_RangeAttribute()
        {
            // Arrange
            var model = new BookedListModel { Amount = 10000 };

            // Act
            var result = ValidateModel(model, "Amount");

            // Assert
            Assert.IsTrue(result);
        }

        // Add more tests for other properties and validation attributes

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
