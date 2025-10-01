using System.Collections.Generic;
using System.Linq;
using Bridge;

namespace StoreBaeltTicketLibrary.Repositories
{
    /// <summary>
    /// Repository for managing Storebælt tickets.
    /// Uses a static list to store all tickets.
    /// </summary>
    public class StoreBaeltRepository : IStoreBaeltRepository
    {
        // Static list for tickets (shared across application)
        private static readonly List<VehicleBase> _tickets = new List<VehicleBase>();

        /// <inheritdoc />
        public void AddTicket(VehicleBase vehicle)
        {
            _tickets.Add(vehicle);
        }

        /// <inheritdoc />
        public List<VehicleBase> GetAllTickets()
        {
            return new List<VehicleBase>(_tickets); // return copy
        }

        /// <inheritdoc />
        public List<VehicleBase> GetTicketsByLicensePlate(string licensePlate)
        {
            return _tickets
                .Where(v => v.Licenseplate != null && v.Licenseplate == licensePlate)
                .ToList();
        }
    }
}
