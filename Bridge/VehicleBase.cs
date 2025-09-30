using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class VehicleBase
    {
        /// <summary>
        /// Gets or sets the license plate number of the vehicle.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with this instance.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// returns the fixed price crossing vehicle.
        /// Must be implemented in derived/child classes.
        /// </summary>
        /// <returns>The price as a double-precision floating-point number.</returns>
        public abstract double Price();

        /// <summary>
        /// Gets/returns the type of the vehicle as a string.
        /// Must be implemented in derived/child classes.
        /// </summary>
        /// <returns>A string representing the type of the vehicle, such as "Car", "Truck", or "Motorcycle".</returns>
        public abstract string VehicleType();
    }
}
