using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Car
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
        /// Gets the fixed price value.
        /// </summary>
        /// <returns>The price as a <see cref="double"/>.</returns>
        public double Price()
        {
                       return 230.0;
        }

        /// <summary>
        /// Returns the type of the vehicle (car).
        /// </summary>
        /// <returns>A string containing the word "Car".</returns>
        public string VehicleType()
        {
                       return "Car";
        }   
    }
}
