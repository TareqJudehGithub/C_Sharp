Console.WriteLine("Inheritance Basics\n");

#region Objects
Car car1 = new Car();
car1.Make = "BMW";
car1.Model = "512";
car1.YearRegistered = 2023;
car1.NumbersOfDoors = 4;
car1.Start();
car1.Stop();
car1.Park();

MotorCycle motor1 = new MotorCycle();
motor1.Make = "Suzzoki";
motor1.Model = "X542";
motor1.YearRegistered = 2020;
motor1.Start();
motor1.Stop();
motor1.Wheelie();


#endregion


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
public class Car : Vehicle
{
    #region Properties
    public int NumbersOfDoors { get; set; }
    #endregion

    #region Methods

    public void Park()
    {
        Console.WriteLine("The car has Parked.");
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



