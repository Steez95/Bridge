using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Bridge;

namespace Bridge.Tests
{
    public class CarTests
    {
        [Fact]
        public void Price_returnsFixedPrice_230()
        {
            // Arrange
            var car = new Car { Licenseplate = "AB12345", Date = DateTime.Now };

            // Act
            var Price = car.Price();

            // Assert
            Assert.Equals(230.0, Price);
        }

        [Fact]
        public void VehicleType_returnsString_Car()
        {
            // Arrange
            var Car = new Car { Licenseplate = "AB12345", Date = DateTime.Now };

            // Act
            var Type = Car.VehicleType();

            // Assert
            Assert.Equals("Car", Type);
        }
    }
}
