namespace CarSystem
{
    internal class AddCar : Car
    {
        internal List<Car> cars = new List<Car>();

        #region Methods
        internal List<Car> AddNewCar()
        {
            int carId = counter;
            Console.WriteLine(counter);
            Console.WriteLine("\nAdd New Car Menu");
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Color: ");
            string color = Console.ReadLine();

            bool isInt = false;
            int year = 0;
            while (isInt == false)
            {
                Console.Write("Year: ");
                isInt = int.TryParse(Console.ReadLine(), out year);
            }
            cars.Add(new Car
            {
                CarId = carId,
                CarModel = model,
                CarMake = manufacturer,
                CarColor = color,
                CarYear = year
            }
            );
            return cars;
        }

        internal void ShowAllCars(List<Car> cars)
        {
            Console.WriteLine("Cars List:");

            var showCars = cars.OrderBy(car => car.CarId).ToList();
            Console.WriteLine("==================");
            showCars.ForEach(Console.WriteLine);
            Console.WriteLine("==================");
        }
        internal void SearchByModelAndMade(List<Car> cars)
        {
            Console.WriteLine("Search Car Menu\n");
            Console.Write("Car model:");
            string carModel = Console.ReadLine();

            Console.Write("Car manufacturer: ");
            string carMaker = Console.ReadLine();

            var searchByModelAndMake = cars.Where
                (
                car =>
                car.CarModel.Equals(carModel, StringComparison.OrdinalIgnoreCase)
                && car.CarMake.Equals(carMaker, StringComparison.OrdinalIgnoreCase)
                ).ToList();

            Console.WriteLine(
                searchByModelAndMake.Any()
                    ? $"Search result:\n {string.Join("\n", searchByModelAndMake)}"
                    : "No cars found."
                );
        }
        #endregion
    }
}

