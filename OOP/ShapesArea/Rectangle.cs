namespace ShapesArea
{
    internal class Rectangle : Shape
    {
        internal double CalculateArea()
        {
            Width = 5;
            Height = 7;
            double area = Width * Height;
            return area;
        }
        internal void ShowResult()
        {
            Console.WriteLine($"Rectangle area = {CalculateArea()} cm.");
        }
    }
}
