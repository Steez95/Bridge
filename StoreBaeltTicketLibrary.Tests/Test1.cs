using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using Xunit;

namespace StoreBaeltTicketLibrary.Tests
{
    public class StoreBaeltCarTests
    {
        [Fact]
        public void Price_WithWeekendDiscount_ShouldApply15PercentOff()
        {
            // Arrange
            var car = new StoreBaeltCar
            {
                Licenseplate = "AB12345",
                Date = new DateTime(2025, 9, 27), // Saturday
                Brobizz = false
            };

            // Act
            double price = car.Price();

            // Assert (230 - 15% = 195.5)
            Assert.Equals(195.5, price, 1);
        }

        [Fact]
        public void PriceWithDiscount_WithWeekendAndBrobizz_ShouldApplyBothDiscounts()
        {
            // Arrange
            var car = new StoreBaeltCar
            {
                Licenseplate = "AB12345",
                Date = new DateTime(2025, 9, 28), // Sunday
                Brobizz = true
            };

            // Act
            double price = car.PriceWithDiscount();

            // Assert (230 → 195.5 after weekend → 175.95 after Brobizz)
            Assert.Equals(175.95, price, 2);
        }

        [Fact]
        public void PriceWithDiscount_WeekdayWithBrobizz_ShouldOnlyApplyBrobizz()
        {
            // Arrange
            var car = new StoreBaeltCar
            {
                Licenseplate = "AB12345",
                Date = new DateTime(2025, 9, 24), // Wednesday
                Brobizz = true
            };

            // Act
            double price = car.PriceWithDiscount();

            // Assert (230 → 207 after Brobizz)
            Assert.Equals(207.0, price, 1);
        }

        [Fact]
        public void PriceWithDiscount_WeekdayWithoutBrobizz_ShouldReturnFullPrice()
        {
            // Arrange
            var car = new StoreBaeltCar
            {
                Licenseplate = "AB12345",
                Date = new DateTime(2025, 9, 25), // Thursday
                Brobizz = false
            };

            // Act
            double price = car.PriceWithDiscount();

            // Assert (no discount applied → 230)
            Assert.Equals(230.0, price, 1);
        }
    }
}
