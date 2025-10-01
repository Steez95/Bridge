using System.Collections.Generic;
using Bridge;

namespace StoreBaeltTicketLibrary.Repositories
{
    /// <summary>
    /// Interface for Storebælt ticket repository.
    /// Defines methods for managing tickets.
    /// </summary>
    public interface IStoreBaeltRepository
    {
        /// <summary>
        /// Adds (buys) a new ticket.
        /// </summary>
        /// <param name="vehicle">The vehicle buying a ticket.</param>
        void AddTicket(VehicleBase vehicle);

        /// <summary>
        /// Gets all tickets.
        /// </summary>
        /// <returns>A list of all tickets (vehicles).</returns>
        List<VehicleBase> GetAllTickets();

        /// <summary>
        /// Gets all tickets for a specific license plate.
        /// </summary>
        /// <param name="licensePlate">The license plate to filter by.</param>
        /// <returns>A list of matching tickets.</returns>
        List<VehicleBase> GetTicketsByLicensePlate(string licensePlate);
    }
}
