using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// represents a car that inherits from VehicleBase
    /// </summary>
    public class Car : VehicleBase
    {
        /// <summary>
        /// Registration number of the car
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with this instance.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// inherits from VehicleBase.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 230.0;
        }

        public object PricedDiscount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// inherits from VehicleBase.
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
