Console.WriteLine("Instance Members\n");

#region Objects
Circle circle1 = new Circle(radius: 2);
Console.WriteLine(circle1.CalculateAreaOfCircle());


#endregion

public class Circle
{
    #region Fields
    public float Pi = 3.141F;
    public int Radius;
    #endregion

    #region Constructors
    public Circle(int radius)
    {
        this.Radius = radius;
    }
    #endregion

    #region Methods
    public float CalculateAreaOfCircle()
    {
        return Pi * (Radius * Radius);
    }
    #endregion
}
