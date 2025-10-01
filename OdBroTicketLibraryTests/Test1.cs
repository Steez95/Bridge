using System;
using Xunit;
using OresundbronTicketLibrary;

namespace OresundbronTicketLibrary.Tests
{
    public class OresundCarTests
    {
        [Fact]
        public void Price_CarWithoutBrobizz_ShouldReturn460()
        {
            var car = new OeresundCar { Licenseplate = "CAR1234", Date = DateTime.Now, Brobizz = false };
            Assert.Equals(460.0, car.Price());
        }

        [Fact]
        public void Price_CarWithBrobizz_ShouldReturn178()
        {
            var car = new OeresundCar { Licenseplate = "CAR1234", Date = DateTime.Now, Brobizz = true };
            Assert.Equals(178.0, car.Price());
        }

        [Fact]
        public void VehicleType_ShouldReturnOresundCar()
        {
            var car = new OeresundCar();
            Assert.Equals("Oresund car", car.VehicleType());
        }
    }

    public class OresundMCTests
    {
        [Fact]
        public void Price_MCWithoutBrobizz_ShouldReturn235()
        {
            var mc = new OeresundMC { Licenseplate = "MC1234", Date = DateTime.Now, Brobizz = false };
            Assert.Equals(235.0, mc.Price());
        }

        [Fact]
        public void Price_MCWithBrobizz_ShouldReturn92()
        {
            var mc = new OeresundMC { Licenseplate = "MC1234", Date = DateTime.Now, Brobizz = true };
            Assert.Equals(92.0, mc.Price());
        }

        [Fact]
        public void VehicleType_ShouldReturnOresundMC()
        {
            var mc = new OeresundMC();
            Assert.Equals("Oresund MC", mc.VehicleType());
        }
    }
}
