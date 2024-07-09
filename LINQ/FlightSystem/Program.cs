using FlightSystem;

internal class Program
{
    static void Main(string[] args)
    {
        // Flight(s) details
        List<Flight> flights = new List<Flight>
        {
            new Flight
            {
                FlightNumber = "\nAB123",
                DepartureCity = "Amm",
                ArrivalCity = "Lond",
                DepartureTime = DateTime.Parse("2024-01-17 08:00"),
                ArrivalTime = DateTime.Parse("2024-01-17 12:00")
            },
            new Flight
            {
                FlightNumber = "\nCD456",
                DepartureCity = "Dubai",
                ArrivalCity = "Masqat",
                 DepartureTime = DateTime.Parse("2024-05-22 11:00"),
                 ArrivalTime = DateTime.Parse("2024-05-22 14:00")
            },
            new Flight
            {
                FlightNumber = "\nEF789",
                DepartureCity = "AMM",
                ArrivalCity = "Dubai",
                 DepartureTime = DateTime.Parse("2024-05-22 10:00"),
                 ArrivalTime = DateTime.Parse("2024-05-22 15:30")
            }
        };

        // User selection menu
        Console.WriteLine("\nFlight Information System");

        while (true)
        {
            Console.WriteLine("\n.1 List all flights");
            Console.WriteLine("2. Search for flights");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3):  ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        ListAllFlight(flights: flights);
                        break;
                    case 2:
                        SearchFlights(flights: flights);
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid entry!");
                        break;
                }
            }
        }
    }
    static void ListAllFlight(List<Flight> flights)
    {
        Console.WriteLine("All flights:");
        flights.ForEach(Console.WriteLine);
    }
    static void SearchFlights(List<Flight> flights)
    {
        Console.WriteLine("Enter departure city:  ");
        string departureCity = Console.ReadLine();

        Console.WriteLine("Enter arrival city:  ");
        string arrivalCity = Console.ReadLine();

        var matchingFlights = flights.Where(
            f => f.DepartureCity.Equals(departureCity, StringComparison.OrdinalIgnoreCase)
            &&
            f.ArrivalCity.Equals(arrivalCity, StringComparison.OrdinalIgnoreCase)
        ).ToList();

        Console.WriteLine(
            matchingFlights.Any()
            ? "\nMatching Flights:\n" + string.Join("\n", matchingFlights)
            : "No matching flights found."
            );
    }
}
