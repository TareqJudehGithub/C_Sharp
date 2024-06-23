/* Car => SportCar   
 * Car => ElectricCar
 * 
 * Car Fields: Model, Year
 * Car Methods: DisplayInfo()
 * Vehicle Methods:  StartEngine(), Accelerate()
 * 
 * SportCar and ElectricCar inhirits from Car and override DisplayInfo()
 * 
*/

using CarExhibit;

internal class Program
{
    static void Main(string[] args)
    {
        // User inputs
        Console.Write("Enter car model: ");
        string model = Console.ReadLine();


        Console.Write("Enter car year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Objects
        Car car = new Car("standard car", 2024);
        SportsCar sportCar = new SportsCar(model, year);
        ElectricCar electricCar = new ElectricCar(model, year);

        sportCar.Model = model;
        electricCar.Model = model;
        sportCar.Year = year;
        electricCar.Year = year;
        int carSpeed = 100;

        Console.WriteLine("\nStandard Car");
        car.DisplayInfo();
        car.OperateVihecle(carSpeed);

        Console.WriteLine("\nSports Car");
        sportCar.DisplayInfo();
        sportCar.OperateVihecle(carSpeed);

        Console.WriteLine("\nElectric Car");
        electricCar.DisplayInfo();
        electricCar.OperateVihecle(carSpeed);
    }
}