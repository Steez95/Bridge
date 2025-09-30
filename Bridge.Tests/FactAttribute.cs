
namespace Bridge.Tests
{
    internal class FactAttribute : Attribute
    {
        [Fact]
        public void VehicleBase_Polymorphism_WorksForCarAndMC()
        {
            VehicleBase car = new Car { Licenseplate = "AB12345", Date = DateTime.Now };
            VehicleBase mc = new MC { Licenseplate = "MC9999", Date = DateTime.Now };

            Assert.Equals(230.0, car.Price());
            Assert.Equals("Car", car.VehicleType());

            Assert.Equals(120.0, mc.Price());
            Assert.Equals("MC", mc.VehicleType());
        }
    }
}