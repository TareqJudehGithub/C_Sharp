Console.WriteLine("StaticMembers\n");

#region Objects
Circle circle1 = new Circle(4);
Circle circle2 = new Circle(5);

Console.WriteLine(circle1.CalculateAreaOfCircle());
Console.WriteLine(circle2.CalculateAreaOfCircle());


#endregion

public class Circle
{
    #region Fields
    static public float PI = 3.141F;
    public int raduis;

    #endregion

    #region Constructors
    public Circle(int raduis)
    {
        this.raduis = raduis;
    }
    #endregion

    #region Methods
    public float CalculateAreaOfCircle()
    {
        return PI * (raduis * raduis);
    }
    #endregion
}
