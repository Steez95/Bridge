using System;
using StoreBaeltTicketLibrary;
using StoreBaeltTicketLibrary.Repositories;

class Program
{
    static void Main()
    {
        IStoreBaeltRepository repo = new StoreBaeltRepository();

        var car1 = new StoreBaeltCar { Licenseplate = "AB12345", Date = DateTime.Now, Brobizz = true };
        var car2 = new StoreBaeltCar { Licenseplate = "CD67890", Date = DateTime.Now, Brobizz = false };

        repo.AddTicket(car1);
        repo.AddTicket(car2);

        Console.WriteLine("All tickets:");
        foreach (var ticket in repo.GetAllTickets())
        {
            Console.WriteLine($"{ticket.VehicleType()} - {ticket.Licenseplate} - {ticket.PriceWithDiscount()} kr");
        }

        Console.WriteLine("\nTickets for AB12345:");
        foreach (var ticket in repo.GetTicketsByLicensePlate("AB12345"))
        {
            Console.WriteLine($"{ticket.VehicleType()} - {ticket.Licenseplate} - {ticket.PriceWithDiscount()} kr");
        }
    }
}
