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
    public class MC
    {
        /// <summary>
        /// Gets or sets the license plate number of the motorcycle.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the crossing.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the fixed price of a motorcycle crossing.
        /// </summary>
        /// <returns>The price of the item as a <see cref="double"/>.</returns>
        public double Price()
        {
            return 120.0;
        }

        /// <summary>
        /// Gets the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the vehicle type. The default value is "MC".</returns>
        public string Vehicle()
        {
            return "MC";
        }

    }
}
