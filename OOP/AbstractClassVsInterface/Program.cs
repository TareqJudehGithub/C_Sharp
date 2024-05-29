Console.WriteLine("Abstract classes vs Interfaces\n");

public abstract class Circle : Shape, IShape, IRectangle
{
    public int Number;
}

public class Shape
{

}

public class Geometry
{

}


public interface IShape
{
    public static int Number;

    // Interfaces methods now can have access modifiers
    private void PrintMe()
    {
        Console.WriteLine("Print this interface method!");
    }
}

public interface IGeometry
{

}

public interface IRectangle : IShape, IGeometry
{

}



