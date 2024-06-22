using ShapesArea;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Area of Shapes\n");

        // Objects
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        circle.ShowResult();
        rectangle.ShowResult();

    }
}