using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Tests
{
    public class BroBizzTests
    {
        [Fact]
        public void PriceWithDiscount_WhenBrobizzIsUsed_Gives10PercentDiscount()
        {
            // Arrange
            var car = new Car { Licenseplate = "AB12345", Date = DateTime.Now, Brobizz = true };

            // Act
            var discountedPrice = car.PricedDiscount();

            // Assert (xUnit allows delta with Assert.Equal(expected, actual, precision))
            Assert.Equals(207.0, discountedPrice); // 230 - 10% = 207
        }

        [Fact]
        public void PriceWithDiscount_WhenBrobizzNotUsed_NoDiscountApplied()
        {
            // Arrange
            var mc = new MC { Licenseplate = "MC12345", Date = DateTime.Now, Brobizz = false };

            // Act
            var price = mc.PricedDiscount();

            // Assert
            Assert.Equals(120.0, price);
        }
    }
}
