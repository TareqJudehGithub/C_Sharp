Console.WriteLine("Default instance Methods\n");

// Objects
Rectangle rectangle1 = new Rectangle();
rectangle1.CalulateArea();
rectangle1.Print();

public class Rectangle : IPolygon
{

    public void CalulateArea()
    {
        Console.WriteLine("This is the derived class implementation - CalculateArea()");
    }

    // Overriding the base method
    public void Print()
    {
        Console.WriteLine("And this is overriding the base method Print()");
    }
}
public interface IPolygon
{
    void Print()
    {
        Console.WriteLine("This is Ipolygon Interface.");
    }
    void CalulateArea();
}

