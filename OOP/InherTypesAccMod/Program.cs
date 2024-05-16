Console.WriteLine("Inheritance Types and Access Modifiers.\n");

#region Objects
Car car1 = new Car
{
    Make = "BMW",
    Model = "512",
    YearRegistered = 2023,
    NumbersOfDoors = 4
};
car1.Start();
car1.Stop();
car1.Park();
Console.WriteLine("");

ElectricCar car2 = new ElectricCar
{
    Make = "Opel",
    Model = "Vectra",
    BatteryCapacity = 1000,
    BatteryLife = 5,
    NumbersOfDoors = 4

};
car2.ShowBatteryInfo();
Console.WriteLine("");

MotorCycle motor1 = new MotorCycle();
motor1.Make = "Suzzoki";
motor1.Model = "X542";
motor1.YearRegistered = 2020;

motor1.Start();
motor1.Stop();
motor1.Wheelie();


#endregion

Console.ReadKey();
public class Vehicle
{
    #region Properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int YearRegistered { get; set; }
    #endregion

    #region Methods
    public void Start()
    {
        Console.WriteLine("The vehicle has started.");
    }
    public void Stop()
    {
        Console.WriteLine("The vehicle has stopped.");
    }
    #endregion
}


public class Car : Vehicle   // Single-level inheritance
{
    #region Properties
    public int NumbersOfDoors { get; set; }
    internal protected int BatteryLife { get; set; }
    #endregion

    #region Methods

    public void Park()
    {
        Console.WriteLine("The car has Parked.");
    }
    #endregion

}

public class ElectricCar : Car     // Single multilevel inheritance             
{
    #region Properties
    public int BatteryCapacity { get; set; }

    #endregion

    #region Methods
    public void ShowBatteryInfo()
    {
        Console.WriteLine(BatteryCapacity + " Watts");
    }
    #endregion
}


public class MotorCycle : Vehicle
{
    #region Properties

    #endregion

    #region Methods    
    public void Wheelie()
    {
        Console.WriteLine("The motorcycle has performed a wheelie.");
    }
    #endregion
}



