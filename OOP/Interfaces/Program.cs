
Console.WriteLine("Interfaces\n");

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
        return (Length * Width) * 2;
    }
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



