using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Tests
{
    public class VehicleBaseTests
    {
        [Fact]
        public void Licenseplate_WhenLongerThan7Characters_ThrowsArgumentException()
        {
            // Arrange
            var car = new Car();

            // Act + Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                car.Licenseplate = "ABCDEFGH"; // 8 chars
            });
        }
    }
}
