Console.WriteLine("Abstract Class\n");

#region Objects
Circle circleOne = new Circle(5);

Console.Write("Welcome, type your name please: ");
circleOne.user = Console.ReadLine();
double circleArea = circleOne.CalculateArea();
circleOne.WelcomeUser();

Console.WriteLine(circleArea);

Console.ReadKey();
#endregion


// Abstract classes
public abstract class Shape
{
    #region Properties
    public string user;
    #endregion

    #region abstract Methods
    public abstract double CalculateArea();
    #endregion

    #region Methods
    public void WelcomeUser()
    {
        Console.WriteLine($"Welcome {user}!");
    }
    #endregion
}


// Derived classes
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        double circleArea = (Math.PI) * (Math.Pow(Radius, 2));
        double roundedArea = Math.Round(circleArea, 2);
        return roundedArea;
    }
    public void WelcomeUser()
    {
        base.WelcomeUser();
    }
}
