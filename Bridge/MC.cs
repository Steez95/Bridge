using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a motorcycle with a license plate number.
    /// </summary>
    /// <remarks>This class provides a property to store and retrieve the license plate number of the
    /// motorcycle.</remarks>
    public class MC : VehicleBase
    {
        /// <summary>
        /// Gets or sets the license plate number of the motorcycle.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// inherits from VehicleBase.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the fixed price of a motorcycle crossing.
        /// </summary>
        /// <returns>The price of the item as a <see cref="double"/>.</returns>
        public override double Price()
        {
            return 120.0;
        }

        public object PricedDiscount()
        {
            throw new NotImplementedException();
        }

        public object Vehicle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// inherits from VehicleBase.
        /// </summary>
        /// <returns>A string representing the vehicle type. The default value is "MC".</returns>
        public override string VehicleType()
        {
            return "MC";
        }

    }
}
