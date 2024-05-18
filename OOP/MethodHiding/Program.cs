Console.WriteLine("Method Hiding\n");


#region Objects
Vehicle vehicle1 = new Vehicle
{
    Make = "GMC",
    Model = "Envoy"
};
vehicle1.Start();
vehicle1.Stop();
Console.WriteLine("");

Car car1 = new Car
{
    Make = "Opel",
    Model = "Vectra",
    BatterLife = 10,
    yearRegistered = 2021,
    NumberOfDoors = 4
};
car1.Start();
car1.Stop();
car1.Park();
Console.WriteLine("");


Console.ReadKey();

#endregion

#region Base Classes
public class Vehicle
{
    #region Properties
    public string Make;
    public string Model;
    public int yearRegistered;
    #endregion

    #region Methods
    public void Start()
    {
        Console.WriteLine("The vehicle has started moving.");
    }
    public void Stop()
    {
        Console.WriteLine("The vehicle now has stopped.");
    }
    #endregion
}
#endregion


#region Derived Classes
public class Car : Vehicle
{
    #region Properties
    public int NumberOfDoors;
    public int BatterLife;
    #endregion

    #region Methods
    // Hiding Start() method in base class Vehicle
    public new void Start()
    {
        // base keyword here invokes the base method (with the same name instead)
        base.Start();

    }

    public void Park()
    {
        Console.WriteLine($"Car {Make} of model {Model} is in parking mode now");
    }
    #endregion
}
public class MotorCycle : Vehicle
{
    #region Properties

    #endregion

    #region Methods
    public void DoWheelie()
    {
        Console.WriteLine($"Motorcycle {Make} of model {Model} is on Wheelie!");
    }
    #endregion
}
#endregion
