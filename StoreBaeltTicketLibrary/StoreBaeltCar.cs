using Bridge; // Frem the external DLL

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Storebæltsbroen Car implementation wit weekend discount
    /// </summary>
    public class StoreBaeltCar : Car
    {
        /// <summary>
        /// Returns the base price with Storebæltsbroen weekend discount.
        /// </summary>
        public override double Price()
        {
            double basePrice = base.Price();

            // Apply 15% discount if Saturday or Sunday
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice *= 0.85; // 15% off
            }

            return basePrice;
        }
        /// <summary>
        /// Calculates the final price including Storebæltsbroen weekend discount
        /// and Brobizz discount (applied afterwards).
        /// </summary>
        public new double PriceWithDiscount()
        {
            double price = Price();

            // Apply Brobizz discount afterwards if enabled
            if (Brobizz)
            {
                price *= 0.9; // 10% off
            }

            return price;
        }
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }
        public bool Brobizz { get; set; }
    }
}