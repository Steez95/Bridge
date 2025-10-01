using Bridge;

namespace OeresundBroenTicketLibrary
{
    /// <summary>
    /// specific car implementation for Øresundsbroen
    /// </summary>
    public class OeresundCar : Car
    {
        /// <summary>
        /// Return the special price for Øresund Car
        /// Normally 560 kr. with Brobizz 278 kr.
        /// </summary>
        /// <returns></returns>
        public override double Price() 
        {
            if (Brobizz)
            {
                return 178.0;
            }
            return 460.0;
        }

        /// <summary>
        /// Returns the Vehicle type string for Øresund Cars.
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
