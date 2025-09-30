using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class VehicleBase
    {
        private string _licenseplate;

        /// <summary>
        /// Gets or sets the license plate number of the vehicle.
        /// License plate must not exceed 7 characters, otherwise and excepition is thrown.
        /// </summary>
        public string Licenseplate 
        { 
            get => _licenseplate;
            set 
            {
                if (value != null && value.Length > 7)
                {
                    throw new ArgumentException("License plate cannot exceed 7 characters.");
                }
                _licenseplate = value;
            }
        }

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
