
Console.WriteLine("Interfaces\n");

#region Objects
// Rectangle class objects
Rectangle rectangle1 = new Rectangle();
rectangle1.Length = 8;
rectangle1.Width = 9;
double rect1area = rectangle1.CalculateArea();
double rec1perm = rectangle1.CalculatePerimeter();
Console.WriteLine($"The area and the perimeter of {nameof(rectangle1)} is {rect1area} and {rec1perm}");

Triangle triangle1 = new Triangle();
triangle1.sideOne = 9;
triangle1.sideTwo = 11;
triangle1.sideThree = 10;
double trian1Area = triangle1.CalculateArea();
double triangle1Perm = triangle1.CalculatePerimeter();
Console.WriteLine($"The area and the perimeter of {nameof(triangle1)} is {trian1Area} and {triangle1Perm}");
#endregion

#region Classes
public class Rectangle : IPolygon
{
    #region Properties
    public double Length { get; set; }
    public double Width { get; set; }
    #endregion
    public double CalculateArea()
    {
        return Length * Width;
    }
    public double CalculatePerimeter()
    {
        return (Length + Width) * 2;
    }
}

public class Triangle : IPolygon
{
    #region Properties

    public double sideOne { get; set; }
    public double sideTwo { get; set; }
    public double sideThree { get; set; }
    #endregion

    #region Methods
    public double CalculateArea()
    {
        double s = (sideOne + sideTwo + sideThree) / 2;
        double area = Math.Sqrt(s * (s - sideOne) * (s - sideTwo) * (s - sideThree));
        return area;
    }

    public double CalculatePerimeter()
    {
        double permiter = sideOne + sideTwo + sideThree;
        return permiter;
    }

    #endregion
}
#endregion


#region Interfaces
public interface IPolygon
{
    #region Methods
    double CalculateArea();
    double CalculatePerimeter();
    #endregion
}
#endregion



