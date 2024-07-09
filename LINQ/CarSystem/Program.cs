using CarSystem;

internal class program
{
    static void Main(string[] args)
    {
        AddCar addCar = new AddCar();

        while (true)
        {
            Console.WriteLine("Welcome to the Cars System!");
            Console.WriteLine("Please selection an option below:");
            Console.WriteLine("1. Add a new car");
            Console.WriteLine("2. List all cars");
            Console.WriteLine("3. Search cars");
            Console.WriteLine("4. Exit program");
            Console.Write("Your choice (1-4): ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                switch (userInput)
                {
                    case 1:

                        addCar.AddNewCar();
                        break;
                    case 2:
                        addCar.ShowAllCars(cars: addCar.cars);
                        break;
                    case 3:
                        addCar.SearchByModelAndMade(cars: addCar.cars);
                        break;
                    case 4:
                        Console.WriteLine("Thank you! Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }

        }

    }
}