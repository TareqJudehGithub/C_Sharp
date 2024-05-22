Console.WriteLine("Constructors\n");

#region Instances
Car obj1 = new Car();
obj1.model = "Honda";
obj1.make = "Jazz";
obj1.PrintCarName();

Car obj2 = new Car();
obj2.PrintCarName();

Car obj3 = new Car();
obj3.make = "Kia";
obj3.model = "Sonet";
#endregion


Console.ReadKey();

public class Car
{
    #region Fields
    public string make;
    public string model;
    #endregion

    #region Constructors

    // Parameterless constructor
    public Car()
    {
        make = "Tesla";
        model = "Model Y";
    }

    // Parameterized constructor
    public Car(string makeValue, string modelValue)
    {
        this.make = makeValue;
        this.model = modelValue;
    }


    #endregion

    #region Methods
    public void PrintCarName()
    {
        Console.WriteLine($"The car is: {make} {model}");
    }
    #endregion


}
