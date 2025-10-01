using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace OeresundBroenTicketLibrary
{
    /// <summary>
    /// Specific Øresund Motorcycle implementation
    /// </summary>
    public class OeresundMC : MC
    {
        /// <summary>
        /// Returns the special price for Øresunc MC.
        /// Normally 235 kr. wuth Brobizz 92 kr.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 92.0;
            }
            return 235.0;
        }

        /// <summary>
        /// returns the vehicle type string for Øresunc MCs.
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Oeresunf MC";
        }
    }
}
