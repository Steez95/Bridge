using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Bridge;

namespace Bridge.Tests
{
    public class MCTests
    {
        [Fact]
        public void Price_WhenCalled_returnsFixedPrice_120()
        {
            // Arrange
            var mc = new MC { Licenseplate = "MC1234", Date = DateTime.Now };

            // Act
            var result = mc.Price();

            // Assert
            Assert.Equals(120.0, result);
        }

        [Fact]
        public void Vehicle_WhenCalled_returnsMC()
        {
            // Arrange
            var mc = new MC { Licenseplate = "MC1234", Date = DateTime.Now };

            // Act
            var result = mc.Vehicle();

            // Assert
            Assert.Equals("MC", result);
        }
    }
}
